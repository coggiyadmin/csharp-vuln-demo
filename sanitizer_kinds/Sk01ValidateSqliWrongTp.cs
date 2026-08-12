using System.Data.SqlClient;
public class Sk01ValidateSqliWrongTp {
  public void Run(string id) {
    var v = id.Replace(";", ""); // wrong sanitizer
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
