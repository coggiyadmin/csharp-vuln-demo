using System.Data.SqlClient;
public class San01AfterConcatTp {
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    q = q.Replace(";", ""); // sanitize AFTER concat — too late / wrong
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
