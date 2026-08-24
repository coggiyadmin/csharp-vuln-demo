using Newtonsoft.Json;
public class Sk12JsonOnlyDeserWrongTp {
  public object Run(string json) {
    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
    return JsonConvert.DeserializeObject(json, settings); // SINK CWE-502
  }
}
