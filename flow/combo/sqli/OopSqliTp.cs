using System.Data.SqlClient;
public class OopSqliTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var q = "SELECT * FROM u WHERE id=" + h.V;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
