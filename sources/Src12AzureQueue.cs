using System.Data.SqlClient;
public class Src12AzureQueue {
  public void OnMessage(string messageText) {
    var q = "SELECT * FROM u WHERE id=" + messageText;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC queue
  }
}
