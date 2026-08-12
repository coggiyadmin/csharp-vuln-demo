public class V09GuardInVariableSafe {
  public object Run(string input) {
    var ok = input.Length < 64;
    if (ok) { _ = input; }
  }
}
