using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
// CWE-257 — reversible password storage (AES with static key).
// FN probe — NO finding = potential FALSE NEGATIVE. (validation pin GAP-257-cs)
public class RecoverablePassword : Controller {
  static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789abcdef");
  static readonly byte[] Iv = Encoding.UTF8.GetBytes("abcdef0123456789");
  [HttpPost("/store")]
  public IActionResult Store([FromForm] string password) {
    using var aes = Aes.Create();
    aes.Key = Key; aes.IV = Iv;
    var enc = aes.CreateEncryptor().TransformFinalBlock(
      Encoding.UTF8.GetBytes(password), 0, password.Length); // reversible → CWE-257
    System.IO.File.WriteAllBytes("/var/app/pw.bin", enc);
    return Ok("ok");
  }
}
