// SAFE — path_traversal: GetFileName strips any directory component
using System.IO;
public class V04ParameterizeSafe {
  public void Run(string input) {
    var name = Path.GetFileName(input);
    var full = Path.Combine("/srv/data", name);
    File.ReadAllText(full);
  }
}
