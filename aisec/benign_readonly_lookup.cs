// TN — readonly dictionary lookup.
using System.Collections.Generic;
public class BenignReadonlyLookup {
  static readonly Dictionary<string, string> Map = new() { ["a"] = "1" };
  public string Get(string k) => Map.TryGetValue(k, out var v) ? v : "";
}
