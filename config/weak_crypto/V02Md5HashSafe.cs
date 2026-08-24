// SAFE — weak_crypto: keyed HMAC-SHA256 instead of a bare MD5 digest.
using System.Security.Cryptography;
using System.Text;
public class V02Md5HashSafe {
  public byte[] Run(string s) {
    var key = RandomNumberGenerator.GetBytes(32);
    using var mac = new HMACSHA256(key);
    return mac.ComputeHash(Encoding.UTF8.GetBytes(s));
  }
}
