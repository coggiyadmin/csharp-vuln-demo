using System.Diagnostics;
/** FP-target — fixed command string. */
public class SafeProcessFixed {
  public void Run() { Process.Start("grep foo /var/log/app.log"); }
}
