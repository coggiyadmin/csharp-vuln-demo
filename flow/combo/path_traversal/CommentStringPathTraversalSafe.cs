using System.IO;
public class CommentStringPathTraversalSafe {
  public string Run(string input) {
    // would be File.ReadAllText("/data/"+input)
    return File.ReadAllText("/data/readme.txt");
  }
}
