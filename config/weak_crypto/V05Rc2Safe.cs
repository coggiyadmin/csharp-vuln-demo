using System.Security.Cryptography;
public class V05Rc2Safe {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.GenerateKey(); aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
