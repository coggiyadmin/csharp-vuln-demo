using System.Data.SqlClient;
public class V33OrderByTp {
  public void Run(string col) {
    var q = "SELECT * FROM u ORDER BY " + col;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
