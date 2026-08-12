using System.Data.SqlClient;
public class San10TryCatchSqliTp {
  public void Run(string input) {
    try {
      var q = "SELECT * FROM u WHERE id=" + input;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
    } catch { }

  }
}
