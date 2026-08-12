using System.Net.Http;
using System.Threading.Tasks;
public class San04BranchOnlySsrfTp {
  public async Task Run(string input) {
    if (input.Length > 0) { /* no real sanitize */ }
    var u = input + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
