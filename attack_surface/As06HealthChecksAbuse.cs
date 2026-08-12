using System.Net.Http; using System.Threading.Tasks;
public class As06HealthChecksAbuse {
  public async Task Check(string target) {
    await new HttpClient().GetAsync(target); // health check SSRF
  }
}
