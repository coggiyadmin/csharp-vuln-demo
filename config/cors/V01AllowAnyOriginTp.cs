using Microsoft.AspNetCore.Builder;
public static class V01AllowAnyOriginTp {
  public static void Configure(WebApplicationBuilder b) {
    b.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyHeader()));
  }
}
