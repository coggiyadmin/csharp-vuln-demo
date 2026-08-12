using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
public class V01BaselineSafe {
  public void Run(string input) {
    JsonSerializer.Deserialize<Dictionary<string, object>>(input);
  }
}
