using System; using System.Xml.XPath; using System.IO; using System.Text.Json;
public class IlEnvJsonToXpath {
  public void Run() {
    var name = JsonDocument.Parse(Environment.GetEnvironmentVariable("PAYLOAD") ?? "{}")
      .RootElement.GetProperty("name").GetString();
    var xp = "//user[@name='" + name + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
