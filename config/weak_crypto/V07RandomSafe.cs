// SAFE — weak_crypto: session token bytes from the cryptographic RNG.
using System.Security.Cryptography;
public class V07RandomSafe {
  public string Token() {
    var bytes = RandomNumberGenerator.GetBytes(32);
    return System.Convert.ToHexString(bytes);
  }
}
