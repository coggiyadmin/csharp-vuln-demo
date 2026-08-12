using System.Net.Http; using System.Threading.Tasks;
public class YarpSsrfSafe {
  public async Task Run(string dest) {
    if (new System.Uri(dest).Host != "backend.internal") return;
    await new HttpClient().GetAsync(dest);
  }
}
