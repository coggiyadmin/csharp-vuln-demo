using System; using System.Reflection;
public class UnsafeSpiEntrypointsTp {
  public object? Run(string typeName) =>
    Activator.CreateInstance(Type.GetType(typeName)!); // SINK user type
}
