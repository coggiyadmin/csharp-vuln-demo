// SAFE — weak_crypto: AES-CBC with a per-message random IV, replacing ECB.
using System.Security.Cryptography;
public class V01AesEcbSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.Mode = CipherMode.CBC;
    aes.Padding = PaddingMode.PKCS7;
    aes.GenerateKey();
    aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
