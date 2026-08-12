using System.Diagnostics;
using System.Linq;
public class San09LinqSelectCommandInjectionTp {
  public void Run(string input) {
    var v = new[] { input }.Select(x => x).First();
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
