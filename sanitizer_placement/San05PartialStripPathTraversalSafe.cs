// SAFE — PathTraversal sanitizer, applied to a truncated copy of the input — GetFileName strips every directory component
using System.IO;
public class San05PartialStripPathTraversalSafe {
  public string Run(string input) {
    var t = input.Length > 64 ? input.Substring(0, 64) : input;
    var v = Path.GetFileName(t);
    return File.ReadAllText("/data/" + v);
  }
}
