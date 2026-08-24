// SAFE — code_injection: wrapper validates before any evaluation
using System.Data;
public class V06CustomWrapperSafe {
  object Result;
  public void Run(string input) {
    Result = Evaluate(input);
  }
  static object Evaluate(string expr) {
    if (!System.Text.RegularExpressions.Regex.IsMatch(expr, "^[0-9+\\-*/ ]+$"))
      return null;
    return new DataTable().Compute(expr, "");
  }
}
