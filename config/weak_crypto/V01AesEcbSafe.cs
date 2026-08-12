using System.Security.Cryptography;
public class V01AesEcbSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.GenerateKey(); aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
