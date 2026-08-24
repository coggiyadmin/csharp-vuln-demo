// SAFE — code_injection: operation chosen from a fixed delegate table; nothing is compiled.
using System.Collections.Generic;
public class V02Safe {
  static readonly Dictionary<string, System.Func<double, double>> Ops = new() {
    ["double"] = x => x * 2,
    ["negate"] = x => -x
  };
  public object Run(string input) {
    if (!Ops.TryGetValue(input, out var op))
      return null;
    return op(21);
  }
}
