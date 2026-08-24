// SAFE — PathTraversal sanitizer, applied inside the only branch that reaches the sink — GetFileName strips every directory component
using System.IO;
public class San04BranchOnlyPathTraversalSafe {
  public string Run(string input) {
    if (input.Length == 0)
      return default;
    var v = Path.GetFileName(input);
    return File.ReadAllText("/data/" + v);
  }
}
