// SAFE — PathTraversal sanitizer, applied by reassigning the same variable — GetFileName strips every directory component
using System.IO;
public class San12ReassignPathTraversalSafe {
  public string Run(string input) {
    var v = input;
    v = Path.GetFileName(v);
    return File.ReadAllText("/data/" + v);
  }
}
