using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class FakeSanDeserializationTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    return new BinaryFormatter().Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(v))); // SINK CWE-502
  }
}
