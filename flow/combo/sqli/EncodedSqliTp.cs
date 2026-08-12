using System.Data.SqlClient;
public class EncodedSqliTp {
  public void Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var q = "SELECT * FROM u WHERE id=" + v;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
