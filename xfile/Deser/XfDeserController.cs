namespace Demo.Xfile.Deser;
public static class XfDeserController {
  public static object Handle(byte[] data) => XfDeserHelper.Load(data);
}
