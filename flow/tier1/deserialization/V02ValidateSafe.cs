// SAFE — deserialization: shape check then a closed, typed target
using System.Text.Json;
public class V02ValidateSafe {
  object Dto;
  public void Run(string input) {
    if (!input.TrimStart().StartsWith("{"))
      return;
    Dto = JsonSerializer.Deserialize<UserDto>(input);
  }
  public class UserDto { public string Name { get; set; }
  }
}
