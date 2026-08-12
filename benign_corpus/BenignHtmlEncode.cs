using System.Web;
/** TN — HtmlEncode before Raw. */
public class BenignHtmlEncode {
  public object Run(string name) => Html.Raw(HttpUtility.HtmlEncode(name));
}
