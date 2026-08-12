using System.Security.Cryptography;
using System.Text;
public class V02Md5HashTp {
  public byte[] Run(string s) => MD5.HashData(Encoding.UTF8.GetBytes(s)); // SINK CWE-328
}
