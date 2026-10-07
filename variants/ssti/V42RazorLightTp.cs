using RazorLight;
public class V42RazorLightTp {
  public async System.Threading.Tasks.Task<string> Run(string tpl, object model) {
    var eng = new RazorLightEngineBuilder().UseMemoryCachingProvider().Build();
    return await eng.CompileRenderStringAsync("k", tpl, model); // SINK
  }
}
