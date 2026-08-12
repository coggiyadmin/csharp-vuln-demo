using Npgsql;
public class V12NpgsqlCommandTp {
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new NpgsqlCommand(q); // SINK CWE-89
  }
}
