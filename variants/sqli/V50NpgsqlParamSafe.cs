using Npgsql;
public class V50NpgsqlParamSafe {
  public void Run(NpgsqlConnection c, string id) {
    using var cmd = new NpgsqlCommand("SELECT * FROM u WHERE id=@id", c);
    cmd.Parameters.AddWithValue("id", id);
  }
}
