using System.Diagnostics;
public class San08FieldStoreCommandInjectionTp {
  string _v;
  public void Set(string input) { _v = input; }
  public void Run() {
    var full = "sh -c " + _v;
    Process.Start(full); // SINK CWE-78
  }
}
