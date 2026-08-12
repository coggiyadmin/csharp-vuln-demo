using System.Diagnostics;
public class UnsafeOsExecTp {
  public void Run(string cmd) => Process.Start("/bin/sh", "-c " + cmd);
}
