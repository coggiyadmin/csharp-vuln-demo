// SAFE — sanitizer_kinds: depth-bounded JSON read into a sealed target type.
using System.Text.Json;
public class Sk12JsonOnlyDeserSafe {
  public Settings Run(string json) {
    var options = new JsonSerializerOptions { MaxDepth = 8, AllowTrailingCommas = false };
    return JsonSerializer.Deserialize<Settings>(json, options);
  }
  public sealed class Settings { public string Theme { get; set; } public int Size { get; set; } }
}
