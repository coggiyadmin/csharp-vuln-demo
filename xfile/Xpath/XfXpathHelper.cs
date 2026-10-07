using System.IO;
using System.Xml.XPath;
namespace Demo.Xfile.Xpath;
public static class XfXpathHelper {
  public static void Select(string name) {
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select("//user[@name='" + name + "']"); // SINK
  }
}
