using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
public class V01JwtNoVerifySafe {
  public void Run(string token, SecurityKey key) {
    var p = new TokenValidationParameters {
      ValidateIssuerSigningKey = true,
      IssuerSigningKey = key,
      ValidateIssuer = false,
      ValidateAudience = false,
    };
    new JwtSecurityTokenHandler().ValidateToken(token, p, out _);
  }
}
