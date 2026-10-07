using System.Xml.XPath;
public class V41XPathEvaluateTp {
  public object Run(XPathNavigator nav, string expr) {
    return nav.Evaluate(expr); // SINK user xpath
  }
}
