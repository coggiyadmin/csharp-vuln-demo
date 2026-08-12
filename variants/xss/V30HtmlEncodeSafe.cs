using System.Net;
public class V30HtmlEncodeSafe {
  public string Run(string user) => WebUtility.HtmlEncode(user);
}
