using System.Data.SqlClient;
public class AgentToolSqlUnscoped {
  public void Query(string sql) {
    var cmd = new SqlCommand(sql, null); // SINK agent tool
  }
}
