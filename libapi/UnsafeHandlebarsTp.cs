public class UnsafeHandlebarsTp {
  public string Run(string tpl) => Scriban.Template.Parse(tpl).Render(); // SINK
}
