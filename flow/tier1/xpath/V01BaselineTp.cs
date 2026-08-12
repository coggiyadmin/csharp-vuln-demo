using System.Xml;
public class V01BaselineTp {
  public void Run(XmlDocument doc, string input) {
    var xp = "//user[name='" + input + "']";
        doc.SelectSingleNode(xp); // SINK CWE-643
  }
}
