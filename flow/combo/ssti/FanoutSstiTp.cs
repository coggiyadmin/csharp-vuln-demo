public class FanoutSstiTp {
  public object Run(string input) {
    var a = input; var b = a; var v = b + b;
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
