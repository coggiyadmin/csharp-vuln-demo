// SAFE — decomposed helpers.
public class SafeLowMi {
  static int Accumulate(int f, int g, int h, int e) {
    int acc = 0;
    for (int i = 0; i < f; i++) {
      if (i % 2 == 0 && g > 0) acc += i * h;
      else if (i % 3 == 0 && e > 0) acc -= i + e;
      else acc ^= g + h;
    }
    return acc;
  }
  public int Orchestrate(int a, int b, int c, int d, int e, int f, int g, int h) {
    if (a <= 0 || b <= 0) return a + b + c;
    if (c > 0 || d > 0) return Accumulate(f, g, h, e) + a + b + c;
    if (e > 0 && f > 0) return a + b + c + d + e + f;
    return a + b + c;
  }
}
