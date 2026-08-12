using System;
using System.Diagnostics;
public class Src15EnvConfig {
  public void Run() {
    var opt = Environment.GetEnvironmentVariable("EXTRA_OPTS");
    var full = "tool " + opt;
    Process.Start(full); // SINK CWE-78 SRC env
  }
}
