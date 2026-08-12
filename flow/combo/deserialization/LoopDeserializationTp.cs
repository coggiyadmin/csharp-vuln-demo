using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class LoopDeserializationTp {
  public object Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
