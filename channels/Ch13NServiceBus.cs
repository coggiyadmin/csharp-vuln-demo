using System.Diagnostics;
public class Ch13NServiceBus {
  public void Handle(string script) {
    Process.Start("sh", "-c " + script);
  }
}
