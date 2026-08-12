using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var fmt = new BinaryFormatter();
            fmt.Deserialize(new MemoryStream(v)); // SINK CWE-502
  }
}
