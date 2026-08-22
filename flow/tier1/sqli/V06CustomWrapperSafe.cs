// SAFE — sqli: local wrapper that always parameterizes
using System.Data.SqlClient;
public class V06CustomWrapperSafe {
  System.Data.SqlClient.SqlConnection conn;
  public void Run(string input) {
    RunByName(input);
  }
  void RunByName(string name) {
    var cmd = new SqlCommand("SELECT * FROM users WHERE name = @name", conn);
    cmd.Parameters.AddWithValue("@name", name);
    cmd.ExecuteNonQuery();
  }
}
