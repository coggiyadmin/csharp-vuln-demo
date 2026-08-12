using YamlDotNet.Serialization;
public class SafeIlYamlGadget {
  public object Run(string yaml) =>
    new DeserializerBuilder().WithAttemptingUnlistedNodes(false).Build().Deserialize<System.Collections.Generic.Dictionary<string, string>>(yaml);
}
