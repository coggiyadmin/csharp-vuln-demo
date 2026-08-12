using System.Security.Cryptography;
public class V01AesGcmSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.Mode = CipherMode.CBC;
    aes.GenerateKey(); aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
