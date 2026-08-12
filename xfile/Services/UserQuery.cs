using System.Data.SqlClient;
namespace Demo.Xfile.Services;
public class UserQuery {
  public void Lookup(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 cross-file
  }
}
