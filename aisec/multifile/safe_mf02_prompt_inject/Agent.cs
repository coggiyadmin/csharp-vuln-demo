public static class Agent {
  public static string Build(string page, string q) =>
    "USER DATA (untrusted):\\n" + page + "\\nQUESTION:\\n" + q;
}
