using System.IO;
public class Sk04FrameworkNativePathSafe {
  public string Run(string p) {
    var name = Path.GetFileName(p);
    return File.ReadAllText(Path.Combine("/data", name));
  }
}
