using System;
using System.Diagnostics;
// cognium-dev #277 — env config as taint source FN probe
// Expect: command_injection. Observed: FN (HttpRequest.Query→same sink fires).
public class Src15EnvConfig {
  public void Run() {
    var opt = Environment.GetEnvironmentVariable("EXTRA_OPTS"); // SOURCE env
    var full = "tool " + opt;
    Process.Start(full); // SINK CWE-78
  }
}
