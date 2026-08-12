using System.Net.Http;
using System.Threading.Tasks;
public class San10TryCatchSsrfTp {
  public async Task Run(string input) {
    try {
      var u = input + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
    } catch { }

  }
}
