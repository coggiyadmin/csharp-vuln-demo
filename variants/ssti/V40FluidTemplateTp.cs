using Fluid;
public class V40FluidTemplateTp {
  public string Run(string tpl, TemplateContext ctx) {
    if (!new FluidParser().TryParse(tpl, out var t)) return "";
    return t.Render(ctx); // SINK user template
  }
}
