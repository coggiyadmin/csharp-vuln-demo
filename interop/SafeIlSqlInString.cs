using System.Data.SqlClient;
public class SafeIlSqlInString {
  public void Run(string user) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE name=@n", null);
    cmd.Parameters.AddWithValue("@n", user);
  }
}
