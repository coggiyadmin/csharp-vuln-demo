using Microsoft.Extensions.Logging;
public class Sk08CrStripLogWrongTp {
  readonly ILogger _log;
  public Sk08CrStripLogWrongTp(ILogger log) => _log = log;
  public void Run(string user) {
    var v = user.Replace("\n", ""); // partial
    _log.LogInformation("user=" + v); // SINK CWE-117
  }
}
