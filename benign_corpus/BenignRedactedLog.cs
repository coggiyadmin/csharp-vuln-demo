using Microsoft.Extensions.Logging;
/** TN — structured log. */
public class BenignRedactedLog {
  readonly ILogger _log;
  public BenignRedactedLog(ILogger log) { _log = log; }
  public void Run(string user) {
    var safe = user.Replace("\r", "_").Replace("\n", "_");
    _log.LogInformation("event=user_lookup value={User}", safe);
  }
}
