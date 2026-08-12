using System.Web;
public class V10HtmlEncodeSafe {
  public object Run(string name) {
    return Html.Raw(HttpUtility.HtmlEncode(name));
  }
}
