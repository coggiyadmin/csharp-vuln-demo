// SAFE — decomposed routing (low CC).
public class SafeComplexHighCc {
  static bool Deep(bool a, bool b, bool c, bool d, bool e) => a && b && c && d && e;
  static bool Mid(bool f, bool g, bool h) => f && g && h;
  public int Route(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h) {
    if (Deep(a, b, c, d, e)) return 1;
    if (Mid(f, g, h)) return 2;
    if (a && f && b && g) return 3;
    return 0;
  }
}
