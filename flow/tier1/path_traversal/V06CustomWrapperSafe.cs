// SAFE — path_traversal: wrapper canonicalizes then enforces the root prefix
using System.IO;
public class V06CustomWrapperSafe {
  public void Run(string input) {
    var full = ResolveUnder("/srv/data", input);
    if (full == null)
      return;
    File.ReadAllText(full);
  }
  static string ResolveUnder(string root, string candidate) {
    var full = Path.GetFullPath(Path.Combine(root, candidate));
    var prefix = Path.GetFullPath(root) + Path.DirectorySeparatorChar;
    return full.StartsWith(prefix) ? full : null;
  }
}
