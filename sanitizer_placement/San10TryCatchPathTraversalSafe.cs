// SAFE — PathTraversal sanitizer, applied inside a try block — GetFileName strips every directory component
using System.IO;
public class San10TryCatchPathTraversalSafe {
  public string Run(string input) {
    try {
      var v = Path.GetFileName(input);
      File.ReadAllText("/data/" + v);
    } catch { }
    return default;
  }
}
