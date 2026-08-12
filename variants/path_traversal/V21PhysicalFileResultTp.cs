using Microsoft.AspNetCore.Mvc;
public class V21PhysicalFileResultTp : Controller {
  public IActionResult Get(string p) {
    var full = "/data/" + p;
    return PhysicalFile(full, "application/octet-stream"); // SINK CWE-22
  }
}
