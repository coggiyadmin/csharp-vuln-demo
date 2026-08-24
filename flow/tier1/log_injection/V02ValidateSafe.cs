// SAFE — log_injection: reject embedded newlines outright
using Microsoft.Extensions.Logging;
public class V02ValidateSafe {
  Microsoft.Extensions.Logging.ILogger Log;
  public void Run(string input) {
    if (input.Contains("\n") || input.Contains("\r"))
      return;
    Log.LogInformation("user={User}", input);
  }
}
