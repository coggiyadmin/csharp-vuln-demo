using System.Security.Cryptography;
public class V06TripleDesSafe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.GenerateKey(); aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
