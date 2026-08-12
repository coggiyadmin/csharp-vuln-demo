using System; using System.Xml.XPath; using System.IO; using System.Text.Json;
public class SafeIlEnvJsonToXpath {
  public void Run() {
    var name = JsonDocument.Parse(Environment.GetEnvironmentVariable("PAYLOAD") ?? "{}")
      .RootElement.GetProperty("name").GetString();
    if (name is null || name.IndexOfAny(new[] { '\'', '"' }) >= 0) return;
    var xp = "//user[@name='" + name + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp);
  }
}
