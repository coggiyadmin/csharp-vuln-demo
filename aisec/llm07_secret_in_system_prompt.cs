// LLM07 — secret embedded in system prompt.
using System;
public class Llm07SecretInSystemPrompt {
  public string BuildPrompt() {
    var key = Environment.GetEnvironmentVariable("INTERNAL_API_KEY");
    return "System: api_key=" + key + ". Answer the user.";
  }
}
