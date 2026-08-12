using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
public class San09LinqSelectSsrfTp {
  public async Task Run(string input) {
    var v = new[] { input }.Select(x => x).First();
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
