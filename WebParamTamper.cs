using Microsoft.AspNetCore.Mvc;
// CWE-472 — trusts client-supplied price (web parameter tampering).
// FN probe — NO finding = potential FALSE NEGATIVE. (validation pin GAP-472-cs)
public class WebParamTamper : Controller {
  [HttpPost("/checkout")]
  public IActionResult Checkout([FromForm] string price, [FromForm] int qty) {
    var total = double.Parse(price) * qty; // SINK CWE-472 trusts client price
    return Ok(new { charged = total });
  }
}
