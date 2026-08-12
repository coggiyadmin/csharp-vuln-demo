public class PrivilegeEscalationSafe {
  public void Elevate(string user, bool allowed) { if (allowed) Role = "admin"; }
  public string Role;
}
