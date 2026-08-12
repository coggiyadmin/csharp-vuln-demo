using System.Web.UI; using System.IO;
public class V30LosFormatterTp {
  public object Run(string data) {
    return new LosFormatter().Deserialize(data); // SINK CWE-502
  }
}
