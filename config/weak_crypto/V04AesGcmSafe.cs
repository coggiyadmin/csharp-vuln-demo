// SAFE — weak_crypto: AES-GCM binding associated data into the authentication tag.
using System.Security.Cryptography;
using System.Text;
public class V04AesGcmSafe {
  public byte[] Run(byte[] data, string context) {
    var key = RandomNumberGenerator.GetBytes(32);
    var nonce = RandomNumberGenerator.GetBytes(AesGcm.NonceByteSizes.MaxSize);
    var cipher = new byte[data.Length];
    var tag = new byte[AesGcm.TagByteSizes.MaxSize];
    using var aes = new AesGcm(key, tag.Length);
    aes.Encrypt(nonce, data, cipher, tag, Encoding.UTF8.GetBytes(context));
    return cipher;
  }
}
