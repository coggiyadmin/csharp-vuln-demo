// SAFE — intake: BinaryFormatter replaced by a typed System.Text.Json read.
using System.Text.Json;
public class BinaryformatterDeserSafe {
  public UserDto Run(string json) => JsonSerializer.Deserialize<UserDto>(json);
  public class UserDto { public string Name { get; set; } }
}
