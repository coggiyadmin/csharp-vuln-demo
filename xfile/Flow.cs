namespace Demo.Xfile;
/** Cross-file composition. */
public static class Flow {
  public static void Run(string id) {
    var v = Source.Read(id);
    Sink.Query(v);
  }
}
