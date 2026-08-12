using System.Security.Claims;
public class TrustBoundarySafe {
  public string Role(ClaimsPrincipal user) => user.FindFirst(ClaimTypes.Role)?.Value ?? "";
}
