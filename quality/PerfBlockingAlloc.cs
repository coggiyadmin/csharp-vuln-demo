// Performance — unbounded allocation anti-pattern.
using System.Collections.Generic;
public class PerfBlockingAlloc {
  public List<byte[]> CollectAll(int[] sizes) {
    var outList = new List<byte[]>();
    foreach (var n in sizes) outList.Add(new byte[n]); // unbounded
    return outList;
  }
}
