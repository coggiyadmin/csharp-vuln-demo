public static class Agent {
  public static string Build(string page, string q) =>
    "SYSTEM:\\n" + page + "\\nUSER:\\n" + q; // splice untrusted into system
}
