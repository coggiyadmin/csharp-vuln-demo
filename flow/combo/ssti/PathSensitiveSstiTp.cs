public class PathSensitiveSstiTp {
  public object Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
