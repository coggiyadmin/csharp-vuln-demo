using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class FanoutDeserializationTp {
  public object Run(string input) {
    var a = input; var b = a; var v = b + b;
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
