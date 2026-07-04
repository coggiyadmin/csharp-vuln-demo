using System.Net.Http;
public class V01BaselineTp {
  public async Task Run(string url) => await new HttpClient().GetStringAsync(url); // SINK
}
