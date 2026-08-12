using System.Data.Common;
public class As21EfInterceptor {
  public void ReaderExecuting(DbCommand cmd, string suffix) {
    cmd.CommandText = cmd.CommandText + " -- " + suffix; // SINK mutate SQL
  }
}
