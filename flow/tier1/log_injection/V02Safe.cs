using Microsoft.Extensions.Logging;
public class V02Safe {
  public void Run(string input) {
    var safe = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());
        _log.LogInformation("user={User}", safe);
  }
}
