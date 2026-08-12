// SAFE — human-in-the-loop gate before automated decision.
public class EuAiActHighRiskSafe {
  public string Decide(double score, bool humanApproved) {
    if (!humanApproved) return "pending_review";
    return score > 0.9 ? "deny" : "allow";
  }
}
