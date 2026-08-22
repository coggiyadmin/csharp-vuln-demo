// SAFE — deserialization: known-types-only contract serializer
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
public class V07HardeningSafe {
  object Dto;
  public void Run(string input) {
    var serializer = new DataContractJsonSerializer(typeof(UserDto));
    using var ms = new MemoryStream(Encoding.UTF8.GetBytes(input));
    Dto = serializer.ReadObject(ms);
  }
  public class UserDto { public string Name { get; set; }
  }
}
