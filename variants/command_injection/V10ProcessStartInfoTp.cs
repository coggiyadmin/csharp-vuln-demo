using System.Diagnostics;
public class V10ProcessStartInfoTp {
  public void Run(string cmd) {
    var full = "sh -c " + cmd;
    var psi = new ProcessStartInfo(full); // SINK CWE-78
    Process.Start(psi);
  }
}
