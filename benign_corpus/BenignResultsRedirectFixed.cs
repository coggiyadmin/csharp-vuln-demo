using Microsoft.AspNetCore.Http;
public static class BenignResultsRedirectFixed {
  public static IResult Go() => Results.Redirect("/home");
}
