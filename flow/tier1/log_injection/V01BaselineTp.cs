using Microsoft.Extensions.Logging;
public class V01BaselineTp {
  public void Run(string input) {
    var line = "user=" + input;
        _log.LogInformation(line); // SINK CWE-117
  }
}
