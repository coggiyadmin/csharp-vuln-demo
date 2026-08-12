public class AgentFnMissingHumanGate {
  public bool RequireApproval => false;
  public string[] Dangerous = { "shell", "payments", "delete" };
}
