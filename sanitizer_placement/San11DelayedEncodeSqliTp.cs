using System.Data.SqlClient;
public class San11DelayedEncodeSqliTp {
  public void Run(string input) {
    var q = "SELECT * FROM u WHERE id=" + input;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
