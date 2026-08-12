using Microsoft.AspNetCore.Http;
using System.IO;
public class Src19MultipartName {
  public async System.Threading.Tasks.Task Run(IFormFile file) {
    var full = "/uploads/" + file.FileName; // SRC multipart filename
    await using var fs = File.Create(full); // SINK CWE-22
    await file.CopyToAsync(fs);
  }
}
