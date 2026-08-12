using System.Data.SqlClient;
/** channel — gRPC-style request DTO. */
public class Ch03GrpcStyle {
  public void Handle(UserRequest req) {
    var q = "SELECT * FROM u WHERE id=" + req.Id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
public class UserRequest { public string Id { get; set; } }
