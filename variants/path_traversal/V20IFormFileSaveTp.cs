using Microsoft.AspNetCore.Http;
using System.IO;
public class V20IFormFileSaveTp {
  public async System.Threading.Tasks.Task Run(IFormFile file, string name) {
    var full = Path.Combine("/uploads", name); // user-controlled name
    await using var fs = File.Create(full); // SINK CWE-22
    await file.CopyToAsync(fs);
  }
}
