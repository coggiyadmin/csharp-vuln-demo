using System.Xml.Linq;
public class V10XDocumentLoadTp {
  public void Run(string path) {
    XDocument.Load(path); // SINK CWE-611
  }
}
