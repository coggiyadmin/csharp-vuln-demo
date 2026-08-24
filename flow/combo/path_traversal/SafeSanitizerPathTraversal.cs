// SAFE — path_traversal combo: filename stripping AND root containment together.
using System.IO;
public class SafeSanitizerPathTraversal {
  public string Run(string input) {
    var name = Path.GetFileName(input);
    var root = Path.GetFullPath("/data") + Path.DirectorySeparatorChar;
    var full = Path.GetFullPath(Path.Combine(root, name));
    if (!full.StartsWith(root))
      return null;
    return File.ReadAllText(full);
  }
}
