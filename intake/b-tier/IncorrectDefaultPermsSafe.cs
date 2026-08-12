using System.IO;
public class IncorrectDefaultPermsSafe {
  public void Run(string path) {
    File.WriteAllText(path, "secret");
    // private file intent (ACL applied externally)
  }
}
