using System.Diagnostics;
namespace Demo.Xfile.Cmdi;
public static class XfCmdiHelper {
  public static void Exec(string arg) {
    Process.Start("/bin/sh", "-c " + arg); // SINK
  }
}
