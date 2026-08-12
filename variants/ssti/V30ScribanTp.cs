public class V30ScribanTp {
  public string Run(string tpl) => Scriban.Template.Parse(tpl).Render(); // SINK CWE-1336
}
