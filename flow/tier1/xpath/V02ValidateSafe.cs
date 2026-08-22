// SAFE — xpath: closed character allowlist leaves no quote or bracket
using System.Xml.XPath;
using System.Xml;
public class V02ValidateSafe {
  string Found;
  public void Run(string input) {
    if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[A-Za-z0-9_]+$"))
      return;
    var doc = new XPathDocument("data.xml");
    doc.CreateNavigator().Select("/users/user[@name='" + input + "']");
  }
}
