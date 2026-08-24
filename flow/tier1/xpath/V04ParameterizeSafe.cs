// SAFE — xpath: XPath variable binding instead of string building
using System.Xml.XPath;
using System.Xml;
public class V04ParameterizeSafe {
  string Found;
  public void Run(string input) {
    var nav = new XPathDocument("data.xml").CreateNavigator();
    var expr = nav.Compile("/users/user[@name=$name]");
    var ctx = new XsltArgumentListContext();
    ctx.AddParam("name", "", input);
    expr.SetContext(ctx);
    nav.Select(expr);
  }
}

public class XsltArgumentListContext : System.Xml.Xsl.XsltContext {
  readonly System.Collections.Generic.Dictionary<string, object> _p = new();
  public void AddParam(string name, string ns, object value) { _p[name] = value; }
  public override System.Xml.XPath.IXsltContextVariable ResolveVariable(string prefix, string name) => null;
  public override System.Xml.XPath.IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] t) => null;
  public override bool Whitespace => false;
  public override bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node) => false;
  public override int CompareDocument(string a, string b) => 0;
}
