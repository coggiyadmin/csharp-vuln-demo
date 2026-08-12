using Microsoft.AspNetCore.Http; using System.IO;
namespace Demo.Xfile.Uploads;
public static class UploadApi {
  public static async System.Threading.Tasks.Task Save(IFormFile file) {
    await Storage.Write(file.FileName, file);
  }
}
