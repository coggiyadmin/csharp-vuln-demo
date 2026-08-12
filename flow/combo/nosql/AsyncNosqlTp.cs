using MongoDB.Bson;
using MongoDB.Driver;
public class AsyncNosqlTp {
  public async System.Threading.Tasks.Task Run(string input, IMongoCollection<BsonDocument> col) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    col.Find(v); // SINK string filter
  }
}
