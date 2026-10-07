using System.Reflection;
public class V40AssemblyLoadTp {
  public void Run(string path) {
    Assembly.LoadFrom(path); // SINK dynamic load
  }
}
