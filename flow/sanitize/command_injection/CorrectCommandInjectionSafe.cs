public class CorrectCommandInjectionSafe {
  public void Run(string q) {
    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("grep", q) { UseShellExecute = false });
  }
}
