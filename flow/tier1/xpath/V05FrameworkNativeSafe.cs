// SAFE — xpath: fixed expression; comparison happens in code
using System.Xml.XPath;
using System.Xml;
using System.Linq;
public class V05FrameworkNativeSafe {
  string Found;
  public void Run(string input) {
    var nav = new XPathDocument("data.xml").CreateNavigator();
    var all = nav.Select("/users/user");
    foreach (XPathNavigator n in all) {
      if (n.GetAttribute("name", "") == input)
        Found = n.Value;
    }
  }
}
