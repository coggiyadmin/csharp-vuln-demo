using System.Xml.XPath;
using System.IO;
public class EncodedXpathTp {
  public void Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
