using YamlDotNet.Serialization;
public class IlYamlGadget {
  public object Run(string yaml) => new DeserializerBuilder().Build().Deserialize<object>(yaml); // SINK
}
