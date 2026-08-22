// SAFE — the secret file is created with owner-only permissions before content is written.
// (Previously this file was byte-identical to IncorrectDefaultPermsTp.cs apart from a comment,
//  so no analyzer could distinguish them and the pair could not be scored honestly.)
using System.IO;
public class IncorrectDefaultPermsSafe {
  public void Run(string path) {
    using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
      File.SetUnixFileMode(path, UnixFileMode.UserRead | UnixFileMode.UserWrite);
      using var writer = new StreamWriter(stream);
      writer.Write("secret");
    }
  }
}
