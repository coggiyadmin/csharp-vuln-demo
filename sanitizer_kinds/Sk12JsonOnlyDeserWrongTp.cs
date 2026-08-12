using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class Sk12JsonOnlyDeserWrongTp {
  public object Run(byte[] data) => new BinaryFormatter().Deserialize(new MemoryStream(data)); // SINK
}
