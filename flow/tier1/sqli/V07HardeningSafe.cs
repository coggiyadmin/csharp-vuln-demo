// SAFE — sqli: stored procedure + typed, length-bounded parameter
using System.Data;
using System.Data.SqlClient;
public class V07HardeningSafe {
  System.Data.SqlClient.SqlConnection conn;
  public void Run(string input) {
    var cmd = new SqlCommand("dbo.GetUserByName", conn);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 128) { Value = input });
    cmd.ExecuteNonQuery();
  }
}
