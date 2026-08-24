// SAFE — log_injection: wrapper strips CR/LF on every path
using Microsoft.Extensions.Logging;
public class V06CustomWrapperSafe {
  Microsoft.Extensions.Logging.ILogger Log;
  public void Run(string input) {
    LogUser(input);
  }
  void LogUser(string raw) {
    var safe = raw.Replace("\r", "").Replace("\n", "");
    Log.LogInformation("user={User}", safe);
  }
}
