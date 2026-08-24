// SAFE — security_headers: HSTS with a long max-age, subdomains and preload.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
public class V03NoHstsSafe {
  public void Configure(HstsOptions options) {
    options.MaxAge = System.TimeSpan.FromDays(365);
    options.IncludeSubDomains = true;
    options.Preload = true;
  }
}
