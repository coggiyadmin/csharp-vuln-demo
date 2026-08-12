public class EncodedSstiTp {
  public object Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}
