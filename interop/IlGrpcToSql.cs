using System.Data.SqlClient;
public class IlGrpcToSql {
  public void OnRpc(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
  }
}
