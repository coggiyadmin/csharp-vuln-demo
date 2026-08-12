using System.Data.SqlClient;
public class San03AliasHopSqliTp {
  public void Run(string input) {
    var a = input;
    var b = a;
    var v = b;
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
