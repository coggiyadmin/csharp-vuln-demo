public class AgentMemoryPoison {
  public void Remember(string note) => Memory.Add(note); // untrusted long-term memory
  static readonly System.Collections.Generic.List<string> Memory = new();
}
