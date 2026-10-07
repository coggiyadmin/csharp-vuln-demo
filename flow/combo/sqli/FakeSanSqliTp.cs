using System.Data.SqlClient;
public class FakeSanSqliTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
