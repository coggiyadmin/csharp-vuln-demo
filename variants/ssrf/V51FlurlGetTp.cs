using Flurl.Http; using System.Threading.Tasks;
public class V51FlurlGetTp {
  public async Task Run(string url) => await url.GetAsync(); // SINK
}
