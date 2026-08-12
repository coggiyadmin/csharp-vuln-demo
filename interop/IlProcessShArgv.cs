using System.Diagnostics;
// FN probe — argv overload (cognium-dev #276)
public class IlProcessShArgv {
  public void Run(string arg) {
    Process.Start("/bin/sh", "-c " + arg); // SINK should fire; currently FN
  }
}
