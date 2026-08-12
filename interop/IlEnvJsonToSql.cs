using System; using System.Data.SqlClient; using System.Text.Json;
public class IlEnvJsonToSql {
  public void Run() {
    var json = Environment.GetEnvironmentVariable("PAYLOAD") ?? "{}";
    var id = JsonDocument.Parse(json).RootElement.GetProperty("id").GetString();
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK env→json→sql
  }
}
