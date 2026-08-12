using System.Net.Http;
using System.Threading.Tasks;
public class San03AliasHopSsrfTp {
  public async Task Run(string input) {
    var a = input;
    var b = a;
    var v = b;
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
