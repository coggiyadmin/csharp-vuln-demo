using Microsoft.AspNetCore.Http; using System.IO; using System.Threading.Tasks;
public class V50IFormFileSaveSafe {
  public async Task Run(IFormFile file) {
    var name = Path.GetFileName(file.FileName);
    await using var fs = File.Create(Path.Combine("/uploads", name));
    await file.CopyToAsync(fs);
  }
}
