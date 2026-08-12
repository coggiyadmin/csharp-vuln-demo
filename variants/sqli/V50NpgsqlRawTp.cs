using Npgsql;
public class V50NpgsqlRawTp {
  public void Run(NpgsqlConnection c, string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    using var cmd = new NpgsqlCommand(q, c); // SINK
  }
}
