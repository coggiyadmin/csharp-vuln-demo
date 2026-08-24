// SAFE — weak_crypto: fill a buffer from the cryptographic RNG, not System.Random.
using System.Security.Cryptography;
public class V03WeakRandomSafe {
  public byte[] Run() {
    var buffer = new byte[32];
    RandomNumberGenerator.Fill(buffer);
    return buffer;
  }
}
