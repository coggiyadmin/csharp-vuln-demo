// SAFE — jwt_verify_disabled: only RS256 is accepted, so "none" cannot be negotiated.
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
public class V03NoneAlgSafe {
  public System.Security.Claims.ClaimsPrincipal Run(string token, SecurityKey key) {
    var parameters = new TokenValidationParameters {
      ValidateIssuerSigningKey = true,
      IssuerSigningKey = key,
      ValidAlgorithms = new[] { SecurityAlgorithms.RsaSha256 },
      ValidateLifetime = true
    };
    return new JwtSecurityTokenHandler().ValidateToken(token, parameters, out _);
  }
}
