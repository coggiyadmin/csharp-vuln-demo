namespace Demo.Xfile.Jobs;
public static class Enqueue {
  public static void Submit(string script) => Worker.Run(script);
}
