using System.Linq;
public class SafeEfLinqLooksLikeSql {
  public object Run(IQueryable<User> q, int id) => q.Where(u => u.Id == id).FirstOrDefault();
}
public class User { public int Id { get; set; } }
