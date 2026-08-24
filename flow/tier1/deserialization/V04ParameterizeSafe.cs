// SAFE — deserialization: deserialize into a fixed DTO — no type name in the payload
using System.Text.Json;
public class V04ParameterizeSafe {
  object Dto;
  public void Run(string input) {
    Dto = JsonSerializer.Deserialize<UserDto>(input);
  }
  public class UserDto { public string Name { get; set; } public int Age { get; set; }
  }
}
