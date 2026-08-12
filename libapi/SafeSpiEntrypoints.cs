using System;
public class SafeSpiEntrypoints {
  static readonly string[] Allow = { "Demo.PluginA", "Demo.PluginB" };
  public object? Run(string typeName) {
    if (Array.IndexOf(Allow, typeName) < 0) return null;
    return Activator.CreateInstance(Type.GetType(typeName)!);
  }
}
