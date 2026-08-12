using System.Diagnostics;
using System.Threading.Tasks;
public class Prp06AsyncCmdi {
  public async Task Run(string arg) {
    var v = await Task.FromResult(arg);
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
