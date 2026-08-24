// TN — parses a model response into a fixed shape with a bounded reader.
using System.Text.Json;
public class BenignParser {
  public Reply Run(string json) {
    var options = new JsonSerializerOptions { MaxDepth = 4 };
    return JsonSerializer.Deserialize<Reply>(json, options);
  }
  public sealed class Reply { public string Text { get; set; } }
}
