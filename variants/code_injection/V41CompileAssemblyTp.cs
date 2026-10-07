using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
public class V41CompileAssemblyTp {
  public void Run(string code) {
    var tree = CSharpSyntaxTree.ParseText(code); // SINK user code compile
    CSharpCompilation.Create("dyn").AddSyntaxTrees(tree);
  }
}
