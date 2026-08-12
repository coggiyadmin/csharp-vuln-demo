using System.Data.SqlClient;
public class Prp10OutParamSqliTp {
  static void Box(string i, out string o) { o = i; }
  public void Run(string input) {
    Box(input, out var v);
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
