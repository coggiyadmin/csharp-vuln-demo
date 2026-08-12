using MySqlConnector;
public class V51MySqlConnectorTp {
  public void Run(MySqlConnection c, string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    using var cmd = new MySqlCommand(q, c);
  }
}
