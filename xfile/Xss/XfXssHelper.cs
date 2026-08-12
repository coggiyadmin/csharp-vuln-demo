namespace Demo.Xfile.Xss;
public static class XfXssHelper {
  public static object Render(string msg) => Html.Raw("<div>" + msg + "</div>"); // SINK
}
