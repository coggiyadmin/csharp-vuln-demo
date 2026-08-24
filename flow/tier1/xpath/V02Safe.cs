// SAFE — xpath: fixed expression; the comparison is performed in code, not in the query.
using System.Xml;
public class V02Safe {
  public XmlNode Run(XmlDocument doc, string input) {
    foreach (XmlNode n in doc.SelectNodes("//user")) {
      if (n.Attributes["name"].Value == input)
        return n;
    }
    return null;
  }
}
