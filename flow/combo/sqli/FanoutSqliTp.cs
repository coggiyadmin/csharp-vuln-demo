using System.Data.SqlClient;
public class FanoutSqliTp {
  public void Run(string input) {
    var a = input; var b = a;
    var q = "SELECT * FROM u WHERE id=" + b;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
