using System; using System.Data.SqlClient; using System.Text.Json;
public class SafeIlEnvJsonToSql {
  public void Run() {
    var json = Environment.GetEnvironmentVariable("PAYLOAD") ?? "{}";
    var id = JsonDocument.Parse(json).RootElement.GetProperty("id").GetString();
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}
