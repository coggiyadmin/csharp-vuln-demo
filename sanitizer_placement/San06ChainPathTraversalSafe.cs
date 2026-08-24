// SAFE — PathTraversal sanitizer, applied at the end of a call chain — GetFileName strips every directory component
using System.IO;
public class San06ChainPathTraversalSafe {
  public string Run(string input) {
    var v = Path.GetFileName(input.Trim().ToLowerInvariant());
    return File.ReadAllText("/data/" + v);
  }
}
