using System.Text.Json;
public class BinaryformatterDeserSafe {
  public object? Run(string json) => JsonSerializer.Deserialize<Dictionary<string, object>>(json);
}
