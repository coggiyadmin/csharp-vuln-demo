using Microsoft.Extensions.Logging;
public class Sk08StructuredLogSafe {
  readonly ILogger _log;
  public Sk08StructuredLogSafe(ILogger log) => _log = log;
  public void Run(string user) => _log.LogInformation("user={User}", user);
}
