// SAFE — weak_crypto: authenticated AES-GCM encryption.
using System.Security.Cryptography;
public class V01AesGcmSafe {
  public byte[] Run(byte[] data) {
    var key = RandomNumberGenerator.GetBytes(32);
    var nonce = RandomNumberGenerator.GetBytes(AesGcm.NonceByteSizes.MaxSize);
    var cipher = new byte[data.Length];
    var tag = new byte[AesGcm.TagByteSizes.MaxSize];
    using var aes = new AesGcm(key, tag.Length);
    aes.Encrypt(nonce, data, cipher, tag);
    return cipher;
  }
}
