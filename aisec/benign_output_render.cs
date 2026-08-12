using System.Net;
public class BenignOutputRender {
  public string Run(string llmOut) => WebUtility.HtmlEncode(llmOut);
}
