using System.Diagnostics;
public class San07CalleeCommandInjectionSafe {
  static void Exec(string a) {
    Process.Start(new ProcessStartInfo("grep", a) { UseShellExecute = false });
  }
  public void Run(string input) => Exec(input);
}
