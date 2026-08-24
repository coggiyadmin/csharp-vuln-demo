// SAFE — log_injection: value carried in a logging scope rather than the message text.
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
public class V02Safe {
  static ILogger _log;
  public void Run(string input) {
    using (_log.BeginScope(new Dictionary<string, object> { ["user"] = input })) {
      _log.LogInformation("login attempt");
    }
  }
}
