using System.Data.SqlClient;
public class WrongSqliTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    var q = "SELECT * FROM u WHERE id=" + v;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
