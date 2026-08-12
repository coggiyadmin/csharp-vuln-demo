using Microsoft.AspNetCore.Http; using System.IO; using System.Threading.Tasks;
public class V50IFormFileSaveTp {
  public async Task Run(IFormFile file) {
    var full = "/uploads/" + file.FileName;
    await using var fs = File.Create(full); // SINK
    await file.CopyToAsync(fs);
  }
}
