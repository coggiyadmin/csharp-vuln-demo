using System.Data.SqlClient;
public class V09GuardInVariableSafe {
  public void Run(string input) {
    var ok = input.Length < 64;
    if (ok) { _ = input; }
  }
}
