using System.Web.UI;
public class ViewstateDeserTp {
  // SharePoint / ViewState deser gadget pattern
  public object Run(string payload) => new LosFormatter().Deserialize(payload); // SINK CWE-502
}
