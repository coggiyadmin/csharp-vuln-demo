using System.Data.SqlClient;
public class AsyncSqliTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var q = "SELECT * FROM u WHERE id=" + v;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
