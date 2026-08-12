using System.Data.SqlClient;
public class San06ChainSqliTp {
  public void Run(string input) {
    var v = input.Trim().ToLowerInvariant();
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
