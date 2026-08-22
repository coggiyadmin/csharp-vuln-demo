// SAFE — code_injection: closed command set; no expression evaluation at all
using System.Collections.Generic;
public class V07HardeningSafe {
  object Result;
  public void Run(string input) {
    var allowed = new HashSet<string> { "sum", "avg", "max" };
    if (!allowed.Contains(input))
      return;
    Result = Apply(input);
  }
  static double Apply(string name) { return name.Length;
  }
}
