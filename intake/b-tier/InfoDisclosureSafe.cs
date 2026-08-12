using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
public class InfoDisclosureSafe : Controller {
  readonly ILogger _log;
  public InfoDisclosureSafe(ILogger log) => _log = log;
  public IActionResult Err() {
    try { throw new System.Exception("fail"); }
    catch (System.Exception ex) { _log.LogError(ex, "failed"); return StatusCode(500); }
  }
}
