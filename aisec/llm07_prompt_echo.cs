// LLM07 — echo secrets back to client.
using System;
public class Llm07PromptEcho {
  public string Handle(string q) {
    var token = Environment.GetEnvironmentVariable("SESSION_TOKEN");
    return "debug token=" + token + " q=" + q;
  }
}
