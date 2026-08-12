using Microsoft.AspNetCore.Builder;
public static class As11SwaggerAnon {
  public static void Configure(WebApplication app) {
    app.UseSwagger(); // anon swagger in prod marker
    app.UseSwaggerUI();
  }
}
