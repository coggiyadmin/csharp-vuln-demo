using System.IO;
public class SafeIlTomlDynImport {
  public string Run(string pluginPath) {
    var name = Path.GetFileName(pluginPath);
    var full = Path.Combine("/plugins", name);
    return File.Exists(full) ? full : "";
  }
}
