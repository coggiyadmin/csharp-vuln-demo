using System.Data.SqlClient;
public class Ch07GrpcService {
  public void Lookup(LookupReq req) {
    var q = "SELECT * FROM u WHERE id=" + req.Id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
public class LookupReq { public string Id { get; set; } }
