// SAFE — owner-only mode on a fixed path. The path is not a parameter, so it is
// not a caller-controlled location, and the mode is owner read/write only.
using System.IO;
public class IncorrectDefaultPermsSafe {
  public void Run() {
    const string path = "/var/app/secrets/token";
    using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
      File.SetUnixFileMode(path, UnixFileMode.UserRead | UnixFileMode.UserWrite);
      using var writer = new StreamWriter(stream);
      writer.Write("secret");
    }
  }
}
