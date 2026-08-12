using System.Data.SqlClient;
public class Prp09TupleSqliTp {
  public void Run(string input) {
    var tup = (input, 1);
    var v = tup.Item1;
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
