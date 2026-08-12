using System.Data.SqlClient;
public class SanP07BranchOnlyTp {
  public void Run(string id, bool debug) {
    if (debug) { /* pretend validate */ }
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
