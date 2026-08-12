using System.Diagnostics;
public class IlProcessPowershell {
  public void Run(string arg) {
    var full = "powershell -Command " + arg;
    Process.Start(full); // SINK process boundary
  }
}
