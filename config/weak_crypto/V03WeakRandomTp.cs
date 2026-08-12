public class V03WeakRandomTp {
  public int Run() => new System.Random().Next(); // SINK CWE-330
}
