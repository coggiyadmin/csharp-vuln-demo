using System.Data.SqlClient;
// cognium-dev #271 — object-carried / field-stored taint FN probe
// Expect: sql_injection. Observed: FN (direct local-var concat fires).
public class Prp02FieldSqli {
  string _id; // field-carried taint
  public void Set(string id) { _id = id; } // SOURCE lands in field
  public void Run() {
    var q = "SELECT * FROM u WHERE id=" + _id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89 through field
  }
}
