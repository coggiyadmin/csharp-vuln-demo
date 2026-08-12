using System.Net.Http;
using System.Threading.Tasks;
public class Prp13CapturedClosureSsrfTp {
  public async Task Run(string input) {
    System.Func<string> get = () => input;
    var v = get();
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
