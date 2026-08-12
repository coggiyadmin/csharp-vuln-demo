using System.Linq;
public class BenignEfLinq {
  public object Run(IQueryable<Item> q, int id) => q.FirstOrDefault(i => i.Id == id);
}
public class Item { public int Id { get; set; } }
