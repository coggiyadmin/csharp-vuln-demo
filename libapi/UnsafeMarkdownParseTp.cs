public class UnsafeMarkdownParseTp {
  public object Run(string md) {
    var html = Softomarkdown.ToHtml(md); // fictional soft markdown → HTML
    return Html.Raw(html); // SINK CWE-79
  }
}
