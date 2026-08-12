using System.Net.Http;
using System.Threading.Tasks;
public class Prp10OutParamSsrfTp {
  static void Box(string i, out string o) { o = i; }
  public async Task Run(string input) {
    Box(input, out var v);
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
