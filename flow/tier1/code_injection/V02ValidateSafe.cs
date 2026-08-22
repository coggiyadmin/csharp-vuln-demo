// SAFE — code_injection: arithmetic-only allowlist, no identifiers callable
using System.Data;
public class V02ValidateSafe {
  object Result;
  public void Run(string input) {
    if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9+\\-*/ ]+$"))
      return;
    Result = new DataTable().Compute(input, "");
  }
}
