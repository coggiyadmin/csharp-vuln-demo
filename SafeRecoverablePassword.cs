using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
public class SafeRecoverablePassword : Controller {
  [HttpPost("/store")]
  public IActionResult Store([FromForm] string password) {
    var hash = Convert.ToHexString(SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(password)));
    System.IO.File.WriteAllText("/var/app/pw.hash", hash); // one-way
    return Ok("ok");
  }
}
