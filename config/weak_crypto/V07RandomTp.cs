using System;
public class V07RandomTp {
  public int Token() => new Random().Next(); // SINK CWE-338
}
