// SAFE — deserialization: wrapper pins the concrete target type
using System.Text.Json;
public class V06CustomWrapperSafe {
  object Dto;
  public void Run(string input) {
    Dto = Parse(input);
  }
  static UserDto Parse(string payload) {
    return JsonSerializer.Deserialize<UserDto>(payload);
  }
  public class UserDto { public string Name { get; set; }
  }
}
