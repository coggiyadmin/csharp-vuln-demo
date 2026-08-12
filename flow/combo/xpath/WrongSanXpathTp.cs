using System.Xml.XPath;
using System.IO;
public class WrongSanXpathTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
