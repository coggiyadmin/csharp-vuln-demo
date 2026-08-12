using System.Diagnostics; using System.Threading; using System.Threading.Tasks;
public class As20HostedService {
  public Task StartAsync(CancellationToken ct) {
    Process.Start("cleanup.sh"); // fixed — still command surface
    return Task.CompletedTask;
  }
}
