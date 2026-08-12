using System.Net.Http;
using System.Threading.Tasks;
public class San07CalleeSsrfTp {
  static string Pass(string s) => s;
  public async Task Run(string input) {
    var v = Pass(input);
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
