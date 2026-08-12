using System.Data.SqlClient;
public class Ch17KafkaConsumer {
  public void OnMessage(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
  }
}
