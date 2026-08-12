// Prompt Injection DIRECT (OWASP LLM01).
using System.Net.Http;
using System.Text;
using System.Text.Json;
public class PromptInjectDirect {
  public string Answer(string userQuestion) {
    var system = "You are a support bot. Follow company policy.\n" + userQuestion;
    var body = JsonSerializer.Serialize(new { model = "gpt-4", messages = new[] { new { role = "system", content = system } } });
    return new HttpClient().PostAsync("https://api.openai.com/v1/chat/completions",
      new StringContent(body, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result;
  }
}
