public class V01BaselineTp {
  public Dictionary<string, object> Run(string role) => new() { ["role"] = role }; // SINK filter
}
