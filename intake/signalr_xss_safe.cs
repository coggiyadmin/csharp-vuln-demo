using System.Net;
public class SignalrXssSafe {
  public string Broadcast(string html) => WebUtility.HtmlEncode(html);
}
