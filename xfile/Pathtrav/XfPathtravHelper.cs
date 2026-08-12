using System.IO;
namespace Demo.Xfile.Pathtrav;
public static class XfPathtravHelper {
  public static string Read(string p) {
    var full = "/data/" + p;
    return File.ReadAllText(full); // SINK
  }
}
