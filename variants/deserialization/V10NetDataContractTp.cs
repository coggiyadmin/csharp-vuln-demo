using System.Runtime.Serialization;
using System.IO;
public class V10NetDataContractTp {
  public void Run(Stream s) {
    new NetDataContractSerializer().Deserialize(s); // SINK CWE-502
  }
}
