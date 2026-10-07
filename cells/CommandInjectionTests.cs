using System.Diagnostics;
// combo #10 — filename matches *Tests.cs; --exclude-tests must suppress the sink
public class CommandInjectionTests {
  public void Run(string input) {
    Process.Start("sh -c " + input); // SINK should be excluded
  }
}
