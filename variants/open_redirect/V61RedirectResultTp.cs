using Microsoft.AspNetCore.Mvc;
public class V61RedirectResultTp {
  public IActionResult Go(string url) => new RedirectResult(url); // SINK
}
