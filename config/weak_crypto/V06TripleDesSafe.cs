// SAFE — weak_crypto: AES-256-CBC with an explicit key size, replacing TripleDES.
using System.Security.Cryptography;
public class V06TripleDesSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.KeySize = 256;
    aes.Mode = CipherMode.CBC;
    aes.GenerateKey();
    aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
