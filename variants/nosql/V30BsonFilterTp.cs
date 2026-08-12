using MongoDB.Bson; using MongoDB.Driver;
public class V30BsonFilterTp {
  public void Run(IMongoCollection<BsonDocument> col, string q) {
    col.Find(q); // SINK CWE-943 string filter
  }
}
