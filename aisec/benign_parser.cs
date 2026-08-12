using System.Text.Json;
public class BenignParser {
  public object? Run(string json) => JsonSerializer.Deserialize<Dictionary<string, object>>(json);
}
