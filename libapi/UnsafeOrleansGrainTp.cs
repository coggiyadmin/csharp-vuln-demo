using System.Data.SqlClient;
public class UnsafeOrleansGrainTp {
  public void OnActivate(string id) {
    var q = "SELECT * FROM grains WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK Orleans grain
  }
}
