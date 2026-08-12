using System.Data.SqlClient;
public class San12ReassignSqliTp {
  public void Run(string input) {
    var v = "safe";
    v = input; // reassign drops sanitize
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
