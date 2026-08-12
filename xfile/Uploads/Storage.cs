using Microsoft.AspNetCore.Http; using System.IO;
namespace Demo.Xfile.Uploads;
public static class Storage {
  public static async System.Threading.Tasks.Task Write(string name, IFormFile file) {
    var full = "/uploads/" + name;
    await using var fs = File.Create(full); // SINK CWE-22
    await file.CopyToAsync(fs);
  }
}
