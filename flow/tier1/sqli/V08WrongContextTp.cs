using System.Data.SqlClient;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = HttpUtility.HtmlEncode(input);
        var q = "SELECT * FROM u WHERE id=" + v;
            var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
