// SAFE — cors: credentialed requests restricted to an explicit origin allowlist.
using Microsoft.AspNetCore.Cors.Infrastructure;
public class V01CorsAllowlistSafe {
  static readonly string[] Origins = { "https://app.example.com", "https://admin.example.com" };
  public void Run(CorsPolicyBuilder builder) {
    builder.WithOrigins(Origins)
           .AllowCredentials()
           .WithHeaders("Authorization", "Content-Type");
  }
}
