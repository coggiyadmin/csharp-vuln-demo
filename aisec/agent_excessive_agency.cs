// Excessive Agency (OWASP LLM06) — unbounded tool scope.
public class AgentExcessiveAgency {
  public string[] Tools = { "filesystem", "shell", "network" };
  public string FilesystemRoot = "/";
  public string ShellAllowlist = "*";
  public bool RequireHumanApproval = false;
}
