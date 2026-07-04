using System.Net;
public class V02Safe {
  public string Run(string msg) => "<p>" + WebUtility.HtmlEncode(msg) + "</p>";
}
