using System.IdentityModel.Tokens.Jwt;
public class V01JwtNoVerifyTp {
  public JwtSecurityToken Run(string token) {
    var handler = new JwtSecurityTokenHandler();
    // SINK CWE-347 — decode without validation
    return handler.ReadJwtToken(token);
  }
}
