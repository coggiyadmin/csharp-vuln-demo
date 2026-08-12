using System.Net;
public class SafeMauiEncode {
  public string Render(string html) => WebUtility.HtmlEncode(html);
}
