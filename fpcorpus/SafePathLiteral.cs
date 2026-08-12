using System.IO;
/** FP-target — literal path. */
public class SafePathLiteral {
  public string Run() => File.ReadAllText("/etc/hosts");
}
