using System.IO;
public class San08FieldStorePathTraversalSafe {
  string _v;
  public void Set(string input) { _v = System.IO.Path.GetFileName(input); }
  public string Run() => File.ReadAllText(System.IO.Path.Combine("/data", _v));
}
