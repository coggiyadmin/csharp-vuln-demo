using System.Xml.XPath;
using System.IO;
public class FanoutXpathTp {
  public void Run(string input) {
    var a = input; var b = a; var v = b + b;
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
