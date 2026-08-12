// TN — fixed system prompt, user role separate.
public class BenignSystemPrompt {
  const string System = "You are a helpful assistant.";
  public object Messages(string user) => new object[] {
    new { role = "system", content = System },
    new { role = "user", content = user },
  };
}
