using System.Net.Http;
// Azure-style pipeline still ends in HttpClient
public class V22AzureHttpPipelineTp {
  public async System.Threading.Tasks.Task Run(string url) {
    var u = url + "?api-version=2024-01-01";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
