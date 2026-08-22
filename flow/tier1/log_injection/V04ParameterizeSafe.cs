// SAFE — log_injection: structured logging — value stays a field, not a line
using Microsoft.Extensions.Logging;
public class V04ParameterizeSafe {
  Microsoft.Extensions.Logging.ILogger Log;
  public void Run(string input) {
    Log.LogInformation("login attempt for {User}", input);
  }
}
