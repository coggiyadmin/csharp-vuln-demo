// SAFE — hardcoded_secrets: connection string resolved from configuration.
using Microsoft.Extensions.Configuration;
public class V02ConnectionStringSafe {
  readonly IConfiguration _config;
  public V02ConnectionStringSafe(IConfiguration config) { _config = config; }
  public string Run() => _config.GetConnectionString("Primary");
}
