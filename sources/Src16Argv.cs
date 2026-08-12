using System.Diagnostics;
public class Src16Argv {
  public static void Main(string[] args) {
    var full = "tool " + args[0];
    Process.Start(full); // SINK CWE-78 SRC argv
  }
}
