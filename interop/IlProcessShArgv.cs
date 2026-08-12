using System.Diagnostics;
// cognium-dev #276 — Process.Start(fileName, arguments) overload FN probe
// Expect: command_injection. Observed: FN (string-form Process.Start(full) fires).
public class IlProcessShArgv {
  public void Run(string arg) {
    // User taint in arguments string — must be modeled like Process.Start("/bin/sh -c " + arg)
    Process.Start("/bin/sh", "-c " + arg); // SINK CWE-78 argv overload
  }
}
