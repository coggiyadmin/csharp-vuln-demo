public class AuthBypassSafe {
  public bool CanAccess(string role, string required) => role == required;
}
