using System.Data.SqlClient;
public class Src18GraphQlVar {
  public void Resolve(string id) { // HotChocolate resolver arg
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC graphql
  }
}
