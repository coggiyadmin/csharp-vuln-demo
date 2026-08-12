using System.Diagnostics;
// cognium-dev #276 + argv source — Main(args) → Process.Start argv overload
// Expect: command_injection. Observed: FN.
public class Src16Argv {
  public static void Main(string[] args) {
    var user = args[0]; // SOURCE argv
    Process.Start("/bin/sh", "-c " + user); // SINK CWE-78 argv overload (#276)
  }
}
