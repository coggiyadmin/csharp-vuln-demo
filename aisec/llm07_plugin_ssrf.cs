using System.Net.Http; using System.Threading.Tasks;
public class Llm07PluginSsrf {
  public async Task Fetch(string url) => await new HttpClient().GetAsync(url); // plugin SSRF
}
