using System.Diagnostics;
using System.Linq;
public class Sk06CustomWrapperCmdiSafe {
  static string Sanitize(string s) => new string(s.Where(char.IsLetterOrDigit).ToArray());
  public void Run(string arg) {
    Process.Start(new ProcessStartInfo("grep", Sanitize(arg)) { UseShellExecute = false });
  }
}
