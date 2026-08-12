// TP — missing human oversight on automated decision (EU AI Act pattern).
public class EuAiActHighRiskTp {
  public string Decide(double score) =>
    score > 0.9 ? "deny" : "allow"; // no human review gate
}
