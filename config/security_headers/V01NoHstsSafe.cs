// SAFE — security_headers: HSTS enabled in the pipeline.
using Microsoft.AspNetCore.Builder;
public class V01NoHstsSafe {
  public void Run(IApplicationBuilder app) {
    app.UseHsts();
    app.UseHttpsRedirection();
  }
}
