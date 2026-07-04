public class V01BaselineTp {
  public void Run(string code) { Evaluator.Eval(code); } // SINK CWE-94
}
static class Evaluator { public static void Eval(string c) => System.Reflection.Assembly.Load(c); }
