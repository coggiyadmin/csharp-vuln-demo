using System.Net.Http;
using System.Threading.Tasks;
public class San08FieldStoreSsrfSafe {
  string _v;
  public void Set(string input) { _v = input; }
  public async Task Run() {
    if (new System.Uri(_v).Host == "api.internal.example.com") await new HttpClient().GetAsync(_v);
  }
}
