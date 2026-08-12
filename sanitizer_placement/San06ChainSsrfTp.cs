using System.Net.Http;
using System.Threading.Tasks;
public class San06ChainSsrfTp {
  public async Task Run(string input) {
    var v = input.Trim().ToLowerInvariant();
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
