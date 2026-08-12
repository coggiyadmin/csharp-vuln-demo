using System.Security.Cryptography;
public class V04DesSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.GenerateKey(); aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
