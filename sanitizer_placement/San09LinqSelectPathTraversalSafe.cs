// SAFE — PathTraversal sanitizer, applied inside a LINQ projection — GetFileName strips every directory component
using System.IO;
using System.Linq;
public class San09LinqSelectPathTraversalSafe {
  public string Run(string input) {
    var v = new[] { input }.Select(x => Path.GetFileName(x)).First();
    return File.ReadAllText("/data/" + v);
  }
}
