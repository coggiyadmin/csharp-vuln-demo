using System.Diagnostics;
public class San08FieldStoreCommandInjectionSafe {
  string _v;
  public void Set(string input) { _v = input; }
  public void Run() {
    Process.Start(new ProcessStartInfo("grep", _v) { UseShellExecute = false });
  }
}
