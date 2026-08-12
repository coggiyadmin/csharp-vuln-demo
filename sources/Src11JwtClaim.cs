using System.Security.Claims;
using System.Data.SqlClient;
public class Src11JwtClaim {
  public void Run(ClaimsPrincipal user) {
    var id = user.FindFirst("sub")?.Value;
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC jwt
  }
}
