using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
public class Ch10HostedService : BackgroundService {
  protected override Task ExecuteAsync(CancellationToken stoppingToken) {
    var opt = System.Environment.GetEnvironmentVariable("JOB_OPTS");
    var full = "job " + opt;
    Process.Start(full); // SINK CWE-78
    return Task.CompletedTask;
  }
}
