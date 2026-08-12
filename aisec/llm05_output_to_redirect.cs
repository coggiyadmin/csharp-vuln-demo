using Microsoft.AspNetCore.Mvc;
public class Llm05OutputToRedirect : Controller {
  public IActionResult Run(string llmOut) => Redirect(llmOut); // SINK
}
