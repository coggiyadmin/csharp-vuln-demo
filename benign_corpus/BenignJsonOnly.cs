using System.Text.Json;
/** TN — JSON only, no BinaryFormatter. */
public class BenignJsonOnly {
  public object Run(string json) => JsonSerializer.Deserialize<Dictionary<string, object>>(json);
}
