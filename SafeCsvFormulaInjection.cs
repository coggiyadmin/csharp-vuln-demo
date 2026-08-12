using System.IO;
using Microsoft.AspNetCore.Mvc;
public class SafeCsvFormulaInjection : Controller {
  [HttpGet("/export")]
  public IActionResult Export([FromQuery] string name) {
    var safe = name.StartsWith("=") || name.StartsWith("+") || name.StartsWith("-") || name.StartsWith("@")
      ? "'" + name : name;
    System.IO.File.AppendAllText("/var/app/export.csv", safe + ",100\n");
    return Ok("exported");
  }
}
