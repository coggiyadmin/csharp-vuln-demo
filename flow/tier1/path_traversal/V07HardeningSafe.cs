// SAFE — path_traversal: canonicalize before the containment check
using System.IO;
public class V07HardeningSafe {
  public void Run(string input) {
    var root = Path.GetFullPath("/srv/data") + Path.DirectorySeparatorChar;
    var full = Path.GetFullPath(Path.Combine(root, input));
    if (!full.StartsWith(root))
      return;
    File.ReadAllText(full);
  }
}
