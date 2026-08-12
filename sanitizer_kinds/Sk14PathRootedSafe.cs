using System.IO;
public class Sk14PathRootedSafe {
  public string Run(string p) {
    var full = Path.GetFullPath(Path.Combine("/data", Path.GetFileName(p)));
    if (!full.StartsWith("/data")) throw new System.UnauthorizedAccessException();
    return File.ReadAllText(full);
  }
}
