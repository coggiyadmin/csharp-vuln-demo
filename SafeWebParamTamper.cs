using Microsoft.AspNetCore.Mvc;
public class SafeWebParamTamper : Controller {
  static readonly System.Collections.Generic.Dictionary<string, double> Catalog = new() {
    ["sku1"] = 9.99, ["sku2"] = 19.99
  };
  [HttpPost("/checkout")]
  public IActionResult Checkout([FromForm] string sku, [FromForm] int qty) {
    if (!Catalog.TryGetValue(sku, out var price)) return BadRequest();
    return Ok(new { charged = price * qty }); // server-side price
  }
}
