using Microsoft.AspNetCore.Http;
public static class V21ResultsRedirectTp {
  public static IResult Go(string next) => Results.Redirect(next); // SINK CWE-601 Minimal API
}
