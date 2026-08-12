using System.Net.Http;
using System.Threading.Tasks;
public class Prp09TupleSsrfTp {
  public async Task Run(string input) {
    var tup = (input, 1);
    var v = tup.Item1;
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
