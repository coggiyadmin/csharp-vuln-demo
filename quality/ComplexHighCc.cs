// McCabe HIGH CC — mirror: SafeComplexHighCc.cs
public class ComplexHighCc {
  public int Route(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h) {
    if (a) { if (b) { if (c) { if (d) { if (e) { return 1; } } } } }
    if (f) { if (g) { if (h) { return 2; } } }
    if (a && f) { if (b && g) { return 3; } }
    return 0;
  }
}
