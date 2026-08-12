using Microsoft.AspNetCore.Mvc;
public class V03EncodeSafe {
  public IActionResult Run(string input) {
    var v = System.Net.WebUtility.UrlEncode(input); _ = v;
  }
}
