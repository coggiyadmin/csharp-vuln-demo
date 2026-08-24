// SAFE — PathTraversal sanitizer, applied at the head of an alias chain — GetFileName strips every directory component
using System.IO;
public class San03AliasHopPathTraversalSafe {
  public string Run(string input) {
    var a = Path.GetFileName(input);
    var b = a;
    var v = b;
    return File.ReadAllText("/data/" + v);
  }
}
