using System.Text.Json;
public class Sk12JsonOnlyDeserSafe {
  public object? Run(string json) => JsonSerializer.Deserialize<Dictionary<string, object>>(json);
}
