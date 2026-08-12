using System;
public class SafeIlEnvToEval {
  public int Run() {
    var code = Environment.GetEnvironmentVariable("CODE") ?? "0";
    return int.TryParse(code, out var n) ? n : 0; // no eval
  }
}
