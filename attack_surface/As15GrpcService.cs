using System.Data.SqlClient;
public class As15GrpcService {
  public void GetUser(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
  }
}
