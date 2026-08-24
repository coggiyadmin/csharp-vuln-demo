// SAFE — jwt_verify_disabled: signature, issuer, audience and lifetime all validated.
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
public class V01JwtNoVerifySafe {
  public System.Security.Claims.ClaimsPrincipal Run(string token, SecurityKey key) {
    var parameters = new TokenValidationParameters {
      ValidateIssuerSigningKey = true,
      IssuerSigningKey = key,
      ValidateIssuer = true,
      ValidIssuer = "https://issuer.example.com",
      ValidateAudience = true,
      ValidAudience = "api",
      ValidateLifetime = true
    };
    return new JwtSecurityTokenHandler().ValidateToken(token, parameters, out _);
  }
}
