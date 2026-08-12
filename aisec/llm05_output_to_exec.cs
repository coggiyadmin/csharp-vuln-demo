// LLM05 — model output into Process.Start.
using System.Diagnostics;
public class Llm05OutputToExec {
  public void Run(string llmOutput) {
    var full = "sh -c " + llmOutput;
    Process.Start(full);
  }
}
