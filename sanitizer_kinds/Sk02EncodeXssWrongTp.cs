using System.Web;
public class Sk02EncodeXssWrongTp {
  public object Run(string msg) {
    var v = HttpUtility.UrlEncode(msg); // wrong context
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
