using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class PathSensitiveDeserializationTp {
  public object Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
