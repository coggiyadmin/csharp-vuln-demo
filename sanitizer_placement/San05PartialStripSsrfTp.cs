using System.Net.Http;
using System.Threading.Tasks;
public class San05PartialStripSsrfTp {
  public async Task Run(string input) {
    var v = input.Replace(";", "");
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
