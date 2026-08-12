using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class V20BinaryFormatterStreamTp {
  public object Run(Stream s) {
    return new BinaryFormatter().Deserialize(s); // SINK CWE-502
  }
}
