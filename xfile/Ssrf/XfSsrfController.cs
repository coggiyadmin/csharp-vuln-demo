namespace Demo.Xfile.Ssrf;
public static class XfSsrfController {
  public static async System.Threading.Tasks.Task Handle(string url) => await XfSsrfHelper.Fetch(url);
}
