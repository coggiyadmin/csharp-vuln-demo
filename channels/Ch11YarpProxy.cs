using System.Net.Http; using System.Threading.Tasks;
public class Ch11YarpProxy {
  public async Task Forward(string dest) {
    await new HttpClient().GetAsync(dest); // reverse-proxy SSRF
  }
}
