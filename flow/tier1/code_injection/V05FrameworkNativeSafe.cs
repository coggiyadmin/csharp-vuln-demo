// SAFE — code_injection: parse to a number instead of evaluating text
public class V05FrameworkNativeSafe {
  object Result;
  public void Run(string input) {
    if (!double.TryParse(input, out var value))
      return;
    Result = value * 2;
  }
}
