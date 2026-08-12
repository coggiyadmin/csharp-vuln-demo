using System.Runtime.Serialization.Formatters.Binary; using System.IO;
namespace Demo.Xfile.Deser;
public static class XfDeserHelper {
  public static object Load(byte[] data) =>
    new BinaryFormatter().Deserialize(new MemoryStream(data)); // SINK
}
