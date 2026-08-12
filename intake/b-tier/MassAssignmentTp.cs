public class MassAssignmentTp {
  public void Update(User u, System.Collections.Generic.Dictionary<string, object> form) {
    foreach (var kv in form) typeof(User).GetProperty(kv.Key)?.SetValue(u, kv.Value); // over-post
  }
}
public class User { public string Role; public string Name; }
