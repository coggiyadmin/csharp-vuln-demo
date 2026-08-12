using System.Runtime.InteropServices;
public static class IlPinvoke {
  [DllImport("libc")]
  static extern int system(string cmd);
  public static void Run(string cmd) => system(cmd); // SINK CWE-78 P/Invoke
}
