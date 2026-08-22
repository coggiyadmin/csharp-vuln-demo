// SAFE — log_injection: strip control characters and bound the length
using Microsoft.Extensions.Logging;
public class V07HardeningSafe {
  Microsoft.Extensions.Logging.ILogger Log;
  public void Run(string input) {
    var safe = input.Replace("\r", "").Replace("\n", "");
    if (safe.Length > 256)
      safe = safe.Substring(0, 256);
    Log.LogInformation("user={User}", safe);
  }
}
