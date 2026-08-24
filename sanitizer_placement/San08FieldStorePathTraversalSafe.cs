// SAFE — PathTraversal sanitizer, applied before the value is stored in a field — GetFileName strips every directory component
using System.IO;
public class San08FieldStorePathTraversalSafe {
  string _v;
  public void Set(string input) { _v = Path.GetFileName(input); }
  public string Run() {
    return File.ReadAllText("/data/" + _v);
  }
}
