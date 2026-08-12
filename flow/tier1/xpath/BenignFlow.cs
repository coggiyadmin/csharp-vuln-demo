using System.Xml;
public class BenignFlow {
  public void Run(XmlDocument doc) {
    doc.SelectSingleNode("//user[name='admin']");
  }
}
