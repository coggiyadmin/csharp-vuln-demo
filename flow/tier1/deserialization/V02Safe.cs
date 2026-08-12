using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
public class V02Safe {
  public void Run(string input) {
    JsonSerializer.Deserialize<Dictionary<string, object>>(input);
  }
}
