using System.IO;
public class Llm05OutputToPath {
  public string Run(string llmOut) {
    var full = "/data/" + llmOut;
    return File.ReadAllText(full); // SINK from LLM output
  }
}
