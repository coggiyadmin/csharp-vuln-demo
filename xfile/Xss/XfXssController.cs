namespace Demo.Xfile.Xss;
public static class XfXssController {
  public static object Handle(string msg) => XfXssHelper.Render(msg);
}
