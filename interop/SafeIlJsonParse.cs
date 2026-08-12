using System.Text.Json;
public class SafeIlJsonParse {
  public int Run(string json) => JsonDocument.Parse(json).RootElement.GetProperty("id").GetInt32();
}
