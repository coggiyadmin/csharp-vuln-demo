using System.Data.SqlClient;
public class San07CalleeSqliTp {
  static string Pass(string s) => s;
  public void Run(string input) {
    var v = Pass(input);
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
