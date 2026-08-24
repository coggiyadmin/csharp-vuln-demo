// SAFE — path_traversal: canonicalize, then require containment under the data root.
using System.IO;
public class V02Safe {
  public string Run(string input) {
    var root = Path.GetFullPath("/data") + Path.DirectorySeparatorChar;
    var full = Path.GetFullPath(Path.Combine(root, input));
    if (!full.StartsWith(root))
      return null;
    return File.ReadAllText(full);
  }
}
