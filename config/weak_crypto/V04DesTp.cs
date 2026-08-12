using System.Security.Cryptography;
public class V04DesTp {
  public byte[] Run(byte[] data) {
    using var des = DES.Create(); // SINK CWE-327
    des.GenerateKey(); des.GenerateIV();
    return des.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
  }
}
