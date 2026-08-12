using Microsoft.AspNetCore.Http;
public class V50ResultsRedirectTp {
  public IResult Run(string next) => Results.Redirect(next); // SINK Minimal API
}
