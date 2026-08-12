using System.Net.Http; using System.Threading.Tasks;
public class YarpSsrfTp {
  public async Task Run(string dest) => await new HttpClient().GetAsync(dest); // SINK reverse-proxy SSRF
}
