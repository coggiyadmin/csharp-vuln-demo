using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class V03EncodeSafe {
  public void Run(string input) {
    var v = System.Net.WebUtility.UrlEncode(input); _ = v;
  }
}
