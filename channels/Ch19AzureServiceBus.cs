using System.Net.Http; using System.Threading.Tasks;
public class Ch19AzureServiceBus {
  public async Task OnMessage(string url) => await new HttpClient().GetAsync(url);
}
