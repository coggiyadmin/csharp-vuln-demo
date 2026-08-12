using Microsoft.Extensions.Logging;
public class V20LoggerTplTp {
  readonly ILogger _log;
  public V20LoggerTplTp(ILogger log) => _log = log;
  public void Run(string user) {
    _log.LogInformation("login user=" + user); // SINK CWE-117
  }
}
