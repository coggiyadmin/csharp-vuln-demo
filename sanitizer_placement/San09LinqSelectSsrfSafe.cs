using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
public class San09LinqSelectSsrfSafe {
  public async Task Run(string input) {
    var v = new[] { input }.First();
    if (new System.Uri(v).Host == "api.internal.example.com") await new HttpClient().GetAsync(v);
  }
}
