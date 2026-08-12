using System.Net.Http;
using System.Threading.Tasks;
public class San11DelayedEncodeSsrfTp {
  public async Task Run(string input) {
    var u = input + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
