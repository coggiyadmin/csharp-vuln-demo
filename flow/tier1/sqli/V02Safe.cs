// SAFE — sqli: stored procedure with a typed, length-bounded parameter.
using System.Data;
using System.Data.SqlClient;
public class V02Safe {
  static SqlConnection conn;
  public void Run(string input) {
    var cmd = new SqlCommand("dbo.GetUserById", conn);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 64) { Value = input });
    cmd.ExecuteNonQuery();
  }
}
