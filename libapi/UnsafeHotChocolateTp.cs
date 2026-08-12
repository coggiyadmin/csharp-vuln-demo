using System.Data.SqlClient;
public class UnsafeHotChocolateTp {
  public void Resolve(string name) {
    var q = "SELECT * FROM u WHERE name=" + name;
    var cmd = new SqlCommand(q, null); // SINK GraphQL resolver
  }
}
