// SAFE — user content stays in user role; system prompt fixed.
using System.Net.Http;
using System.Text;
using System.Text.Json;
public class SafePromptInjectDirect {
  const string System = "You are a support bot. Follow company policy.";
  public string Answer(string userQuestion) {
    var body = JsonSerializer.Serialize(new {
      model = "gpt-4",
      messages = new object[] {
        new { role = "system", content = System },
        new { role = "user", content = userQuestion },
      }
    });
    return new HttpClient().PostAsync("https://api.openai.com/v1/chat/completions",
      new StringContent(body, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result;
  }
}
