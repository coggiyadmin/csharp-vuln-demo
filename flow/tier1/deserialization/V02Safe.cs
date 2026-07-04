using System.Text.Json;
public class V02Safe { public void Run(string json) => JsonSerializer.Deserialize<Dictionary<string, object>>(json); }
