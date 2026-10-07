using Microsoft.Azure.Cosmos;
public class V43CosmosQueryTp {
  public void Run(Container c, string filter) {
    c.GetItemQueryIterator<dynamic>("SELECT * FROM c WHERE " + filter); // SINK
  }
}
