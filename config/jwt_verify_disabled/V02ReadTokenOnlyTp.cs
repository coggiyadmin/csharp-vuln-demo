using System.IdentityModel.Tokens.Jwt;
public class V02ReadTokenOnlyTp {
  public JwtSecurityToken Run(string token) => new JwtSecurityTokenHandler().ReadJwtToken(token); // no validate
}
