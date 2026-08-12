public class InputValidationSafe {
  public int Parse(string raw) {
    if (!int.TryParse(raw, out var n) || n < 0 || n > 1000) throw new System.ArgumentOutOfRangeException();
    return n;
  }
}
