// SAFE — xpath: wrapper emits a quoted XPath literal
using System.Xml.XPath;
using System.Xml;
public class V06CustomWrapperSafe {
  string Found;
  public void Run(string input) {
    var nav = new XPathDocument("data.xml").CreateNavigator();
    nav.Select("/users/user[@name=" + XpathLiteral(input) + "]");
  }
  static string XpathLiteral(string raw) {
    return raw.Contains("'") ? "concat('" + raw.Replace("'", "',\"'\",'") + "')" : "'" + raw + "'";
  }
}
