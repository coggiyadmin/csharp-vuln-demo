using System.Diagnostics;
using System.Linq;
public class San09LinqSelectCommandInjectionSafe {
  public void Run(string input) {
    var v = new[] { input }.First();
    Process.Start(new ProcessStartInfo("grep", v) { UseShellExecute = false });
  }
}
