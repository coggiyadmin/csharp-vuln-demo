using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;
public class V03EncodeSafe {
  public void Run(string input) {
    var v = System.Net.WebUtility.UrlEncode(input); _ = v;
  }
}
