using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
public class V01BaselineTp {
  public void Run(byte[] input) {
    var fmt = new BinaryFormatter();
    fmt.Deserialize(new MemoryStream(input)); // SINK CWE-502
  }
}
