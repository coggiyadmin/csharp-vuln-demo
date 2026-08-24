// SAFE — code_injection: operation selected from a fixed table
using System.Collections.Generic;
public class V04ParameterizeSafe {
  object Result;
  public void Run(string input) {
    var ops = new Dictionary<string, System.Func<double, double, double>> {
      ["add"] = (a, b) => a + b,
      ["mul"] = (a, b) => a * b
    };
    if (!ops.TryGetValue(input, out var op))
      return;
    Result = op(2, 3);
  }
}
