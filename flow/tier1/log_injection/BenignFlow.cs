using Microsoft.Extensions.Logging;
public class V03Benign {
  public void Run() {
    _log.LogInformation("user=system");
  }
}
