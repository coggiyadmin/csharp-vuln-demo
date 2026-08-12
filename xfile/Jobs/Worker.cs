using System.Diagnostics;
namespace Demo.Xfile.Jobs;
public static class Worker {
  public static void Run(string script) {
    Process.Start("sh", "-c " + script); // SINK CWE-78
  }
}
