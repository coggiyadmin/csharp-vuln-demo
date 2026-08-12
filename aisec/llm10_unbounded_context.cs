// LLM10 — unbounded context consumption.
using System.Collections.Generic;
public class Llm10UnboundedContext {
  public string Build(IEnumerable<string> docs) {
    var ctx = string.Join("\n", docs); // no token budget
    return "Answer using:\n" + ctx;
  }
}
