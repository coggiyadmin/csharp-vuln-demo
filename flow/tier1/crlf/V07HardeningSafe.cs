using Microsoft.AspNetCore.Http;
public class V07HardeningSafe {
  public void Run(string input) {
    if (input.All(c => char.IsLetterOrDigit(c) || c == '_')) Response.Headers.Add("X-Trace", input);
  }
}
