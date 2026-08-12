using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class AsyncDeserializationTp {
  public async System.Threading.Tasks.Task<object> Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK
  }
}
