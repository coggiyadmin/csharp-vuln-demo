using Microsoft.AspNetCore.Http;
namespace Demo.Xfile.Crlf;
public static class XfCrlfController {
  public static void Handle(HttpResponse res, string v) => XfCrlfHelper.Write(res, v);
}
