public class V20RazorEngineTp {
  public string Run(string tpl) {
    // RazorEngine / dynamic compile surface
    return Razor.Parse(tpl); // SINK CWE-1336
  }
}
