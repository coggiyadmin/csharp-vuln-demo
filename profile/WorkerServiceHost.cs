using System.Diagnostics;
public class WorkerServiceHost {
  public void Handle(string job) {
    var full = "worker " + job;
    Process.Start(full); // SINK hosted worker
  }
}
