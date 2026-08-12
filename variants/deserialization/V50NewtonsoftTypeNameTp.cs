using Newtonsoft.Json;
public class V50NewtonsoftTypeNameTp {
  public object? Run(string json) =>
    JsonConvert.DeserializeObject(json, new JsonSerializerSettings {
      TypeNameHandling = TypeNameHandling.All // SINK CWE-502
    });
}
