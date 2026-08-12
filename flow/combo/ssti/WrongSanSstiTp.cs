public class WrongSanSstiTp {
  public object Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
