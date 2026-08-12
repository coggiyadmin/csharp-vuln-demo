using Microsoft.Extensions.Logging;
namespace Demo.Xfile.Loginj;
public static class XfLoginjHelper {
  public static void Log(string user) {
    // logger injected at call site in real apps
    System.Console.WriteLine("user=" + user); // SINK CWE-117
  }
}
