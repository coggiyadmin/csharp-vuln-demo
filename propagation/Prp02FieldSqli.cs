using System.Data.SqlClient;
public class Prp02FieldSqli {
  string _id;
  public void Set(string id) { _id = id; }
  public void Run() {
    var q = "SELECT * FROM u WHERE id=" + _id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
