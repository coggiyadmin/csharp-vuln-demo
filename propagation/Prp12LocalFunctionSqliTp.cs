using System.Data.SqlClient;
public class Prp12LocalFunctionSqliTp {
  public void Run(string input) {
    string Wrap(string s) => s;
    var v = Wrap(input);
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
