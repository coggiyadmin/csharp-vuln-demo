using System.Xml.XPath;
using System.IO;
public class AsyncXpathTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}
