using System.Data.SqlClient;
public class SafeOrleansGrain {
  public void OnActivate(string id) {
    var cmd = new SqlCommand("SELECT * FROM grains WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}
