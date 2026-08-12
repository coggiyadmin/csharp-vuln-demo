using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class OopDeserializationTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public object Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
