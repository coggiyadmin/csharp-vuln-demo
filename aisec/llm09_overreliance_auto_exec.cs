using System.Diagnostics;
public class Llm09OverrelianceAutoExec {
  public void Run(string llmCmd) {
    Process.Start("sh", "-c " + llmCmd); // auto-exec without human gate
  }
}
