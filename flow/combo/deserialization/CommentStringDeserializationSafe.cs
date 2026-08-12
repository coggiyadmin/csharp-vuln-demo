using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class CommentStringDeserializationSafe {
  public object Run(string input) {
    // would be Deserialize(input)
    return new { ok = true };
  }
}
