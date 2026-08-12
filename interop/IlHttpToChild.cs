using System.Net.Http; using System.Diagnostics; using System.Threading.Tasks;
public class IlHttpToChild {
  public async Task Run(string url) {
    var body = await new HttpClient().GetStringAsync(url); // SSRF then exec
    Process.Start("sh", "-c echo " + body);
  }
}
