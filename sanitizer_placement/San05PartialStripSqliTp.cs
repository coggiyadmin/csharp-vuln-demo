using System.Data.SqlClient;
public class San05PartialStripSqliTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
