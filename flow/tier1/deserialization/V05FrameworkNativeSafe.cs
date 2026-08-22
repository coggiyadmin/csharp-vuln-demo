// SAFE — deserialization: System.Text.Json cannot instantiate arbitrary types
using System.Text.Json;
public class V05FrameworkNativeSafe {
  object Dto;
  public void Run(string input) {
    var options = new JsonSerializerOptions { MaxDepth = 8 };
    Dto = JsonSerializer.Deserialize<UserDto>(input, options);
  }
  public class UserDto { public string Name { get; set; }
  }
}
