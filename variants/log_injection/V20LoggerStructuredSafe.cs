using Microsoft.Extensions.Logging;
public class V20LoggerStructuredSafe {
  readonly ILogger _log;
  public V20LoggerStructuredSafe(ILogger log) => _log = log;
  public void Run(string user) => _log.LogInformation("login user={User}", user);
}
