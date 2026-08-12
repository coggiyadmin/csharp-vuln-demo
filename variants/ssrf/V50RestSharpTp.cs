using RestSharp; using System.Threading.Tasks;
public class V50RestSharpTp {
  public async Task Run(string url) {
    var client = new RestClient(url);
    await client.ExecuteAsync(new RestRequest()); // SINK
  }
}
