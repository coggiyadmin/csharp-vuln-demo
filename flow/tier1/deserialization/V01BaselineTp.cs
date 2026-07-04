using System.Runtime.Serialization.Formatters.Binary;
public class V01BaselineTp {
  public void Run(byte[] data) { new BinaryFormatter().Deserialize(new MemoryStream(data)); } // SINK
}
