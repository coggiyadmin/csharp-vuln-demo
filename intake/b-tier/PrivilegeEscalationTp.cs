public class PrivilegeEscalationTp {
  public void Elevate(string user) { Role = "admin"; } // unconditional elevate
  public string Role;
}
