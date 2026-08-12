using Microsoft.AspNetCore.Builder;
public static class V03SessionCookieTp {
  public static void Configure(WebApplicationBuilder b) {
    b.Services.AddSession(o => { o.Cookie.HttpOnly = false; o.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.None; });
  }
}
