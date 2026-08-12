using System.Security.Cryptography;
public class V06TripleDesTp {
  public byte[] Run(byte[] data) {
    using var c = TripleDES.Create(); // SINK CWE-327
    c.GenerateKey(); c.GenerateIV();
    return c.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
