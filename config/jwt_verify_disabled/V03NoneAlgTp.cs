using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
public class V03NoneAlgTp {
  public void Run(string token) {
    var p = new TokenValidationParameters {
      ValidateIssuerSigningKey = false,
      RequireSignedTokens = false,
    };
    new JwtSecurityTokenHandler().ValidateToken(token, p, out _); // SINK
  }
}
