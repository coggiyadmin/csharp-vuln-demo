// SAFE — weak_crypto: AES-CBC with a PBKDF2-derived key, replacing DES.
using System.Security.Cryptography;
public class V04DesSafe {
  public byte[] Run(byte[] data, string password) {
    var salt = RandomNumberGenerator.GetBytes(16);
    using var kdf = new Rfc2898DeriveBytes(password, salt, 210000, HashAlgorithmName.SHA256);
    using var aes = Aes.Create();
    aes.Key = kdf.GetBytes(32);
    aes.Mode = CipherMode.CBC;
    aes.GenerateIV();
    return aes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
