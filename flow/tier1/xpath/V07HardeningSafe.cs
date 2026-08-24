// SAFE — xpath: hardened reader plus a closed allowlist
using System.Xml.XPath;
using System.Xml;
public class V07HardeningSafe {
  string Found;
  public void Run(string input) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    using var reader = XmlReader.Create("data.xml", settings);
    var nav = new XPathDocument(reader).CreateNavigator();
    if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[A-Za-z0-9_]+$"))
      return;
    nav.Select("/users/user[@name='" + input + "']");
  }
}
