using System.Xml.XPath;
using System.IO;
public class LoopXpathTp {
  public void Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
