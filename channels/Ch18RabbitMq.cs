using System.Diagnostics;
public class Ch18RabbitMq {
  public void OnMessage(string body) {
    Process.Start("sh", "-c " + body);
  }
}
