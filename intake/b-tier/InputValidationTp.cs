public class InputValidationTp {
  public int Parse(string raw) => int.Parse(raw); // SINK CWE-20 — improper input validation: no range check
}
