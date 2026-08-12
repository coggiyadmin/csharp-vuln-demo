using Microsoft.AspNetCore.Http;
using System.IO;
public class V20IFormFileGetFileNameSafe {
  public async System.Threading.Tasks.Task Run(IFormFile file) {
    var name = Path.GetFileName(file.FileName);
    var full = Path.Combine("/uploads", name);
    await using var fs = File.Create(full);
    await file.CopyToAsync(fs);
  }
}
