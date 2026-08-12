using Microsoft.Extensions.Logging;
public class BenignFlow {
  public void Run() {
    _log.LogInformation("user=system");
  }
}
