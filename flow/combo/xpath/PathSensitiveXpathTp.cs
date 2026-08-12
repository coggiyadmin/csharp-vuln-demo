using System.Xml.XPath;
using System.IO;
public class PathSensitiveXpathTp {
  public void Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
