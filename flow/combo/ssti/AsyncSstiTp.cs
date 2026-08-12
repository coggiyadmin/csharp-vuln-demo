public class AsyncSstiTp {
  public async System.Threading.Tasks.Task<object> Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
