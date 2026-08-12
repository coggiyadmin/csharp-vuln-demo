using Microsoft.AspNetCore.Http;
public class V10ResponseWriteTp {
  public void Run(HttpResponse Response, string name) {
    var s = "<div>" + name + "</div>";
    Response.Write(s); // SINK CWE-79
  }
}
