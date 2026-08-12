using System.Diagnostics;
public class CorrectCommandInjectionSafe {
  public void Run(string q) {
    Process.Start(new ProcessStartInfo("grep", q) { UseShellExecute = false });
  }
}
