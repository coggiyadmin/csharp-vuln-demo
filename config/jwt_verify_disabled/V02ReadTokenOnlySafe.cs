// SAFE — jwt_verify_disabled: claims are read only from the validated principal.
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
public class V02ReadTokenOnlySafe {
  public string Run(string token, SecurityKey key) {
    var parameters = new TokenValidationParameters {
      ValidateIssuerSigningKey = true,
      IssuerSigningKey = key,
      ValidateLifetime = true
    };
    var principal = new JwtSecurityTokenHandler().ValidateToken(token, parameters, out _);
    return principal.Claims.First(c => c.Type == "sub").Value;
  }
}
