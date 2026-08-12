using MySqlConnector;
public class V23MySqlConnectorTp {
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new MySqlCommand(q); // SINK CWE-89
  }
}
