public class LoopSstiTp {
  public object Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
