using System; using System.Diagnostics;
public class Prp15MemoryMarshalCmdiTp {
  public void Run(string input) {
    var mem = input.AsMemory();
    var v = mem.ToString();
    var full = "sh -c " + v;
    Process.Start(full);
  }
}
