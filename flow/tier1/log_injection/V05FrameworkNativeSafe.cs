// SAFE — log_injection: value carried in a logging scope, never in the message
using Microsoft.Extensions.Logging;
public class V05FrameworkNativeSafe {
  Microsoft.Extensions.Logging.ILogger Log;
  public void Run(string input) {
    using (Log.BeginScope(new System.Collections.Generic.Dictionary<string, object> { ["user"] = input })) {
      Log.LogInformation("login attempt");
    }
  }
}
