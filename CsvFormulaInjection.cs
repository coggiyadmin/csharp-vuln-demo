using System.IO;
using Microsoft.AspNetCore.Mvc;
// CWE-1236 — CSV Formula Injection. User input written into a CSV cell that begins
// with =, +, -, or @ executes as a formula when opened in a spreadsheet.
// FN probe — NO finding = potential FALSE NEGATIVE. (validation pin GAP-1236-cs)
public class CsvFormulaInjection : Controller {
  [HttpGet("/export")]
  public IActionResult Export([FromQuery] string name) {
    // name = '=cmd|"/c calc"!A1' becomes an executable formula in Excel → CWE-1236
    var row = name + ",100\n"; // SOURCE → CSV cell
    System.IO.File.AppendAllText("/var/app/export.csv", row); // SINK CWE-1236
    return Ok("exported");
  }
}
