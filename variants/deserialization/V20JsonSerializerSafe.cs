using System.Text.Json;
public class V20JsonSerializerSafe {
  public Dictionary<string, object>? Run(string json) =>
    JsonSerializer.Deserialize<Dictionary<string, object>>(json);
}
