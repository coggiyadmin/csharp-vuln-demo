// SAFE — deserialization: contract serializer bound to one known type.
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
public class V02Safe {
  public object Run(string input) {
    var serializer = new DataContractJsonSerializer(typeof(UserDto));
    using var ms = new MemoryStream(Encoding.UTF8.GetBytes(input));
    return serializer.ReadObject(ms);
  }
  public class UserDto { public string Name { get; set; } }
}
