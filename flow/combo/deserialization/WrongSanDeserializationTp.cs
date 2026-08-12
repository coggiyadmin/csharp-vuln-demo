using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class WrongSanDeserializationTp {
  public object Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
