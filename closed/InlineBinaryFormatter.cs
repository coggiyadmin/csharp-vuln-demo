using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// cognium-dev#630 — inline receiver must still be a deserialization sink
public class InlineBinaryFormatter {
  public static object FromBytes(byte[] data) {
    return new BinaryFormatter().Deserialize(new MemoryStream(data)); // SINK CWE-502
  }
}
