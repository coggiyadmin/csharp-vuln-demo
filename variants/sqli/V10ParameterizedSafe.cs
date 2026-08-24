// SAFE — sqli variant: SqlParameter with an explicit type and size.
using System.Data;
using System.Data.SqlClient;
public class V10ParameterizedSafe {
  static SqlConnection conn;
  public void Run(string id) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", conn);
    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 64) { Value = id });
    cmd.ExecuteNonQuery();
  }
}
