using System.Web;
public class Sk02EncodeXssSafe {
  public object Run(string msg) => Html.Raw(HttpUtility.HtmlEncode(msg));
}
