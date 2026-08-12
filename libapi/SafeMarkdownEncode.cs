using System.Net;
public class SafeMarkdownEncode {
  public string Run(string md) => WebUtility.HtmlEncode(md);
}
