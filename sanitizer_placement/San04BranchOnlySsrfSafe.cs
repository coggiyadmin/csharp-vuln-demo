using System.Net.Http;
using System.Threading.Tasks;
public class San04BranchOnlySsrfSafe {
  public async Task Run(string input) {
    if (new System.Uri(input).Host != "api.internal.example.com") return;
    await new HttpClient().GetAsync(input);
  }
}
