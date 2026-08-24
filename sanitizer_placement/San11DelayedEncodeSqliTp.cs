using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San11DelayedEncodeSqliTp {
  static SqlConnection conn;
  public void Run(string input) {
    var q = "SELECT * FROM u WHERE id=" + input;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89 — encoding below happens too late
    var encoded = Regex.Replace(input, "[^A-Za-z0-9_]", "");
    System.Console.WriteLine(encoded);
  }
}
