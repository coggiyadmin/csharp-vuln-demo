using System.IO;
using System.Linq;
public class San09LinqSelectPathTraversalSafe {
  public string Run(string input) {
    var v = System.IO.Path.GetFileName(new[] { input }.First());
    return File.ReadAllText(System.IO.Path.Combine("/data", v));
  }
}
