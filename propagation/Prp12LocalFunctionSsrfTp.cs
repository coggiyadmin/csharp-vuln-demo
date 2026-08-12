using System.Net.Http;
using System.Threading.Tasks;
public class Prp12LocalFunctionSsrfTp {
  public async Task Run(string input) {
    string Wrap(string s) => s;
    var v = Wrap(input);
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
