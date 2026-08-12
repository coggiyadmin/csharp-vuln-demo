using System.Net.Http;
using System.Threading.Tasks;
public class Prp01InlineSsrf {
  public async Task Run(string url) {
    var u = url + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
