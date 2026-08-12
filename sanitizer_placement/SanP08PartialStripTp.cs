using System.Data.SqlClient;
public class SanP08PartialStripTp {
  public void Run(string id) {
    var v = id.Replace("'", ""); // partial strip
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
