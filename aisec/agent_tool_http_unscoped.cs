using System.Net.Http; using System.Threading.Tasks;
public class AgentToolHttpUnscoped {
  public async Task Get(string url) => await new HttpClient().GetAsync(url);
}
