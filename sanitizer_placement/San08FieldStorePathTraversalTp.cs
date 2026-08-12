using System.IO;
public class San08FieldStorePathTraversalTp {
  string _v;
  public void Set(string input) { _v = input; }
  public object Run() {
    var full = "/data/" + _v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
