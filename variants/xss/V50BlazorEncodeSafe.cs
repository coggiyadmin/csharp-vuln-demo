using System.Net;
public class V50BlazorEncodeSafe {
  public string Run(string html) => WebUtility.HtmlEncode(html);
}
