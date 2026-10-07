namespace Demo.Xfile.Ssti;
public static class XfSstiController {
  public static string Handle(string tpl) => XfSstiHelper.Render(tpl);
}
