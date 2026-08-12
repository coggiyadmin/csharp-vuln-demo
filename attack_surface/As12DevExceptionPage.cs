using Microsoft.AspNetCore.Builder;
public static class As12DevExceptionPage {
  public static void Configure(WebApplication app) {
    app.UseDeveloperExceptionPage(); // SINK CWE-209 in prod
  }
}
