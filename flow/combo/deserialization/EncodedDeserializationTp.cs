using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class EncodedDeserializationTp {
  public object Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
