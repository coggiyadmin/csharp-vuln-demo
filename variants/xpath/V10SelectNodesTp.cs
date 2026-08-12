using System.Xml;
public class V10SelectNodesTp {
  public void Run(XmlDocument doc, string u) {
    var xp = "//user[name='" + u + "']";
    doc.SelectNodes(xp); // SINK CWE-643
  }
}
