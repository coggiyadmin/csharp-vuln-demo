using System.Web;
using System.Linq;
public class SanP06SanitizeChainSafe {
  public object Run(string msg) {
    var v = new string(msg.Where(char.IsLetterOrDigit).ToArray());
    v = HttpUtility.HtmlEncode(v);
    return Html.Raw("<div>" + v + "</div>");
  }
}
