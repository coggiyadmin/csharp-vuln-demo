using Microsoft.Extensions.Logging;
public class V01BaselineSafe {
  public void Run(string input) {
    var safe = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());
        _log.LogInformation("user={User}", safe);
  }
}
