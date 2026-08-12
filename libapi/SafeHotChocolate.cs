using System.Data.SqlClient;
public class SafeHotChocolate {
  public void Resolve(string name) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE name=@n", null);
    cmd.Parameters.AddWithValue("@n", name);
  }
}
