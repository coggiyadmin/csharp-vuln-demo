using System.Net.Http;
using System.Threading.Tasks;
public class San08FieldStoreSsrfTp {
  string _v;
  public void Set(string input) { _v = input; }
  public async Task Run() {
    var u = _v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
