using System.Net.Http;
using System.Threading.Tasks;
public class V03EncodeSafe {
  public async Task Run(string input) {
    var v = System.Net.WebUtility.UrlEncode(input); _ = v;
  }
}
