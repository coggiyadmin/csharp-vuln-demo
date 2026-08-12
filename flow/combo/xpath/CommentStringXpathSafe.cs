using System.Xml.XPath;
using System.IO;
public class CommentStringXpathSafe {
  public void Run(string input) {
    // would be Select with input
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select("//user");
  }
}
