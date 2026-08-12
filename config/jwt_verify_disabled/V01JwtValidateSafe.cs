using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
public class V01JwtValidateSafe {
  public object Run(string token, TokenValidationParameters p) {
    var handler = new JwtSecurityTokenHandler();
    return handler.ValidateToken(token, p, out _);
  }
}
