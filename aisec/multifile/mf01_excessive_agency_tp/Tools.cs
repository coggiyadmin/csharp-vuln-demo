using System.Diagnostics;
public static class Tools {
  public static void Shell(string cmd) => Process.Start("/bin/sh", "-c " + cmd);
}
