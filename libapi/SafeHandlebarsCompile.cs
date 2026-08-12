public class SafeHandlebarsCompile {
  // constant template — no user SSTI
  public string Run(string name) => $"Hello {System.Net.WebUtility.HtmlEncode(name)}";
}
