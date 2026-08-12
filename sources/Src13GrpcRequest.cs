using System.Data.SqlClient;
public class Src13GrpcRequest {
  public void Handle(LookupRequest req) {
    var q = "SELECT * FROM u WHERE id=" + req.UserId;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC grpc
  }
}
public class LookupRequest { public string UserId { get; set; } }
