// SAFE — PathTraversal sanitizer, applied late, immediately before the sink — GetFileName strips every directory component
using System.IO;
public class San11DelayedEncodePathTraversalSafe {
  public string Run(string input) {
    var t = input;
    var length = t.Length;
    var v = Path.GetFileName(t);
    return File.ReadAllText("/data/" + v);
  }
}
