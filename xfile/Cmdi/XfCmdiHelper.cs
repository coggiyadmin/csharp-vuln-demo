using System.Diagnostics;
namespace Demo.Xfile.Cmdi;
// cognium-dev #276 — cross-file helper uses argv Process.Start overload
// Expect (dir or single): command_injection. Observed: FN.
public static class XfCmdiHelper {
  public static void Exec(string arg) {
    Process.Start("/bin/sh", "-c " + arg); // SINK argv overload
  }
}
