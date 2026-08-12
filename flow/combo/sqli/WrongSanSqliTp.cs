using System.Data.SqlClient;
public class WrongSanSqliTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var q = "SELECT * FROM u WHERE id=" + v;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
