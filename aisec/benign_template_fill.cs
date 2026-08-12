public class BenignTemplateFill {
  public string Run(string name) => $"Hello {System.Net.WebUtility.HtmlEncode(name)}";
}
