using System.Runtime.Serialization.Formatters.Binary; using System.IO;
public class BinaryformatterDeserTp {
  public object Run(byte[] data) => new BinaryFormatter().Deserialize(new MemoryStream(data)); // SINK
}
