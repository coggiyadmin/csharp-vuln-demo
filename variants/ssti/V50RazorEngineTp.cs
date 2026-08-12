public class V50RazorEngineTp {
  public string Run(string tpl) => RazorLight.Engine.CompileRenderStringAsync("k", tpl, new { }).Result; // SINK
}
