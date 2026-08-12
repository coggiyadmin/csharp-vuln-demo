using System.Data.SqlClient;
public class V01BaselineTp {
  public void Run(string input) {
    var q = "SELECT * FROM u WHERE id=" + input;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
