using System.IO;
using System.Linq;
public class San09LinqSelectPathTraversalTp {
  public object Run(string input) {
    var v = new[] { input }.Select(x => x).First();
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
