using System.Net.Http; using System.Threading.Tasks;
public class As16AzureFunctionHttp {
  public async Task Run(string url) => await new HttpClient().GetAsync(url);
}
