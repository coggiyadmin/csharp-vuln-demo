using Microsoft.Extensions.Logging;
public class V40ILoggerConcatTp {
  public void Run(ILogger log, string user) {
    log.LogInformation("login " + user); // SINK log injection
  }
}
