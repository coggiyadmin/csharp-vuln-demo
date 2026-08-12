using System.Diagnostics;
public class SafeIlShellInString {
  public void Run(string arg) {
    if (arg is not ("ok" or "ping")) return;
    Process.Start("true"); // fixed argv — no user taint into process
  }
}
