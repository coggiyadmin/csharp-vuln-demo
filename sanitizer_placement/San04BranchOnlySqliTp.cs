using System.Data.SqlClient;
public class San04BranchOnlySqliTp {
  public void Run(string input) {
    if (input.Length > 0) { /* no real sanitize */ }
    var q = "SELECT * FROM u WHERE id=" + input;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
