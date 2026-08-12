using System.Security.Cryptography;
public class V01AesEcbTp {
  public byte[] Run(byte[] data) {
    using var aes = Aes.Create();
    aes.Mode = CipherMode.ECB; // SINK CWE-327
    aes.Key = new byte[16];
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
