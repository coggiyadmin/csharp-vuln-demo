namespace Demo.Xfile.Codeinj;
public static class XfCodeController {
  public static System.Threading.Tasks.Task Handle(string code) => XfCodeHelper.Eval(code);
}
