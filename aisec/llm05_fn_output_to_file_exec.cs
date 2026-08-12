using System.IO; using System.Diagnostics;
public class Llm05FnOutputToFileExec {
  public void Run(string llmOut) {
    File.WriteAllText("/tmp/run.sh", llmOut);
    Process.Start("/bin/sh", "/tmp/run.sh");
  }
}
