using System.Security.Cryptography;
public class V05Rc2Tp {
  public byte[] Run(byte[] data) {
    using var c = RC2.Create(); // SINK CWE-327
    c.GenerateKey(); c.GenerateIV();
    return c.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
