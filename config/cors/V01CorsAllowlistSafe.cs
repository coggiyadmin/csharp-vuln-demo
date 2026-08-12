using Microsoft.AspNetCore.Builder;
public static class V01CorsAllowlistSafe {
  public static void Configure(WebApplicationBuilder b) {
    b.Services.AddCors(o => o.AddDefaultPolicy(p => p.WithOrigins("https://app.example.com")));
  }
}
