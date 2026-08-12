public class BenignRagTenantFilter {
  public string Search(string tenant, string q) => $"tenant={tenant};q={q}";
}
