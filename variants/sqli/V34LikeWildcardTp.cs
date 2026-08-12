using System.Data.SqlClient;
public class V34LikeWildcardTp {
  public void Run(string name) {
    var q = "SELECT * FROM u WHERE name LIKE '%" + name + "%'";
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
