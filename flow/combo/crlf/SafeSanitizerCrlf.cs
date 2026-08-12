using Microsoft.AspNetCore.Http;
public class SafeSanitizerCrlf {
  public void Run(string input, HttpResponse res) {
    _ = input; // sanitized / no sink
  }
}
