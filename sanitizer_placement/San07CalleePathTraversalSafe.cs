// SAFE — PathTraversal sanitizer, applied inside a helper the caller delegates to — GetFileName strips every directory component
using System.IO;
public class San07CalleePathTraversalSafe {
  static string Clean(string x) { return Path.GetFileName(x); }
  public string Run(string input) {
    var v = Clean(input);
    return File.ReadAllText("/data/" + v);
  }
}
