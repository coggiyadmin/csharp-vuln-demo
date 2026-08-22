// SAFE — sqli: ADO.NET parameter binding — value never becomes SQL structure
using System.Data.SqlClient;
public class V05FrameworkNativeSafe {
  System.Data.SqlClient.SqlConnection conn;
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM users WHERE name = @name", conn);
    cmd.Parameters.AddWithValue("@name", input);
    cmd.ExecuteNonQuery();
  }
}
