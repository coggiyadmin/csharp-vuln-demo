using System.Security.Cryptography;
using System.Text;
public class V02Sha256Safe {
  public byte[] Run(string s) => SHA256.HashData(Encoding.UTF8.GetBytes(s));
}
