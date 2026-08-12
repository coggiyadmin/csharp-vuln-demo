using System.Diagnostics;
public class San06ChainCommandInjectionSafe {
  public void Run(string input) {
    var v = new string(input.Where(char.IsLetterOrDigit).ToArray());
    Process.Start(new ProcessStartInfo("grep", v) { UseShellExecute = false });
  }
}
