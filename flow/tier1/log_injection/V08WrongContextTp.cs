using Microsoft.Extensions.Logging;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var line = "user=" + v;
            _log.LogInformation(line); // SINK CWE-117
  }
}
