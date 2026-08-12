using System.Data.SqlClient;
public class San08FieldStoreSqliTp {
  string _v;
  public void Set(string input) { _v = input; }
  public void Run() {
    var q = "SELECT * FROM u WHERE id=" + _v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
