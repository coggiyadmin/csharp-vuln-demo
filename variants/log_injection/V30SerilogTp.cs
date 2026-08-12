using Microsoft.Extensions.Logging;
public class V30SerilogTp {
  readonly ILogger _log;
  public V30SerilogTp(ILogger log) => _log = log;
  public void Run(string user) => _log.LogWarning("auth fail user=" + user); // SINK
}
