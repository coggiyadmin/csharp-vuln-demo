public class PrivilegeEscalationTp {
  public void Elevate(string user) { Role = "admin"; } // SINK CWE-269 — improper privilege management: unconditional elevate
  public string Role;
}
