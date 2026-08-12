using Microsoft.AspNetCore.Mvc;
public class CommentStringOpenRedirectSafe {
  public IActionResult Run(string input) {
    // would be Redirect(input)
    return new RedirectResult("/home");
  }
}
