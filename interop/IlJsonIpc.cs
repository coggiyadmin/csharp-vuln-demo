using System.Text.Json; using System.Data.SqlClient;
public class IlJsonIpc {
  public void OnMessage(string json) {
    var id = JsonDocument.Parse(json).RootElement.GetProperty("id").GetString();
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
  }
}
