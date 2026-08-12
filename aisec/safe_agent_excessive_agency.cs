// SAFE — least-privilege tool scope with human approval.
public class SafeAgentExcessiveAgency {
  public string[] Tools = { "read_file" };
  public string FilesystemRoot = "/app/data";
  public string[] ShellAllowlist = { };
  public bool RequireHumanApproval = true;
}
