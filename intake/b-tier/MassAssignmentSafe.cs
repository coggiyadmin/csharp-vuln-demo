public class MassAssignmentSafe {
  public void Update(User u, string name) { u.Name = name; } // allowlisted fields only
}
public class User { public string Role; public string Name; }
