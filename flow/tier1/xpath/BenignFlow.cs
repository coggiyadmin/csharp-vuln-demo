using System.Xml;
public class V03Benign {
  public void Run(XmlDocument doc) {
    doc.SelectSingleNode("//user[name='admin']");
  }
}
