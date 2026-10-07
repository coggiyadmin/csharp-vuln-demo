namespace Demo.Xfile.Ssti;
public static class XfSstiHelper {
  public static string Render(string tpl) => Scriban.Template.Parse(tpl).Render(); // SINK
}
