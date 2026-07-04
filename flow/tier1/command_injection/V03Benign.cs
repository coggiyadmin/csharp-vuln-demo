using System.Diagnostics;
public class V03Benign {
  public void Run() { Process.Start("grep", "foo"); }
}
