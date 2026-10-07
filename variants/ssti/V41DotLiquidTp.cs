using DotLiquid;
public class V41DotLiquidTp {
  public string Run(string tpl) => Template.Parse(tpl).Render(); // SINK
}
