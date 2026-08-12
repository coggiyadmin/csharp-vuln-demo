using System.Runtime.Serialization.Json; using System.IO;
public class V40DataContractJsonTp {
  public object Run(Stream s) {
    var ser = new DataContractJsonSerializer(typeof(object));
    return ser.ReadObject(s); // polymorphic risk marker
  }
}
