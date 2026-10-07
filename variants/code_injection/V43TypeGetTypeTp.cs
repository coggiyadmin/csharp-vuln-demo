using System;
public class V43TypeGetTypeTp {
  public object Run(string typeName) {
    return Activator.CreateInstance(Type.GetType(typeName)!); // SINK type name
  }
}
