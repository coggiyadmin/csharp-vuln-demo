using System.Runtime.Serialization.Json;
using System.IO;
// Architect: prefer System.Text.Json; DataContractJsonSerializer on untrusted streams is risk surface
public class V21DataContractJsonLooseTp {
  public object Run(Stream s) {
    var ser = new DataContractJsonSerializer(typeof(object));
    return ser.ReadObject(s); // SINK-ish CWE-502 family
  }
}
