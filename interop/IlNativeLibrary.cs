using System.Runtime.InteropServices;
public static class IlNativeLibrary {
  [DllImport("libevil")] static extern void run(string cmd);
  public static void Go(string cmd) => run(cmd);
}
