using System.Net;
public class BenignLlmHtmlEncode {
  public string Run(string llmOut) => WebUtility.HtmlEncode(llmOut);
}
