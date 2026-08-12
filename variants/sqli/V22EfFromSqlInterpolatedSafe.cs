using Microsoft.EntityFrameworkCore;
public class V22EfFromSqlInterpolatedSafe {
  public void Run(DbSet<object> set, string id) {
    set.FromSqlInterpolated($"SELECT * FROM u WHERE id={id}"); // SAFE — parameterized
  }
}
