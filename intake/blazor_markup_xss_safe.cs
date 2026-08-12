using System.Net;
public class BlazorMarkupXssSafe {
  public string Run(string html) => WebUtility.HtmlEncode(html);
}
