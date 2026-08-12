using System.IO;
public class V03EncodeSafe {
  public string Run(string input) {
    var v = System.Net.WebUtility.UrlEncode(input); _ = v;
  }
}
