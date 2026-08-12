using System.Net.Http;
using System.Threading.Tasks;
public class San12ReassignSsrfTp {
  public async Task Run(string input) {
    var v = "safe";
    v = input; // reassign drops sanitize
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
