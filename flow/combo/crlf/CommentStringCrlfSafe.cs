using Microsoft.AspNetCore.Http;
public class CommentStringCrlfSafe {
  public void Run(string input, HttpResponse res) {
    // would be Headers[input]
    res.Headers["X-User"] = "ok";
  }
}
