using System.Diagnostics;
using System.Web;
// cognium-dev#633 — constant init, then tainted reassignment inside if
public class CookieReassignIf {
  public void Bad(HttpRequest req) {
    string data = "";
    HttpCookieCollection cookieSources = req.Cookies; // SOURCE
    if (req != null) {
      data = cookieSources[0].Value;
    }
    Process.Start("cmd.exe /c dir " + data); // SINK CWE-78
  }
}
