// SAFE — capped allocation.
using System.Collections.Generic;
using System.Linq;
public class SafePerfStreamed {
  const int Max = 4096;
  public IEnumerable<byte[]> CollectAll(int[] sizes) =>
    sizes.Take(100).Select(n => new byte[System.Math.Min(n, Max)]);
}
