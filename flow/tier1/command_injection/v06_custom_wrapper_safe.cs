using System.Diagnostics;
public class V06CustomWrapperSafe {
  static void ExecSafe(string a) {
    Process.Start(new ProcessStartInfo("grep", a){UseShellExecute=false});
  }
  public void Run(string input) => ExecSafe(input);
}
