using System.IO;
using System.Xml.XPath;
public class FakeSanXpathTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select("//user[@name='" + v + "']"); // SINK CWE-643
  }
}
