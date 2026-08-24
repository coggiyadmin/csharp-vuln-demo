// SAFE — weak_crypto: ChaCha20-Poly1305 AEAD, replacing RC2.
using System.Security.Cryptography;
public class V05Rc2Safe {
  public byte[] Run(byte[] data) {
    var key = RandomNumberGenerator.GetBytes(32);
    var nonce = RandomNumberGenerator.GetBytes(12);
    var cipher = new byte[data.Length];
    var tag = new byte[16];
    using var aead = new ChaCha20Poly1305(key);
    aead.Encrypt(nonce, data, cipher, tag);
    return cipher;
  }
}
