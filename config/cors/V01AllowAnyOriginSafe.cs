// SAFE — cors: a single explicit origin rather than AllowAnyOrigin.
using Microsoft.AspNetCore.Cors.Infrastructure;
public class V01AllowAnyOriginSafe {
  public void Run(CorsPolicyBuilder builder) {
    builder.WithOrigins("https://app.example.com")
           .WithMethods("GET", "POST");
  }
}
