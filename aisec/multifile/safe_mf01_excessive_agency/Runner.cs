public static class Runner {
  public static void Dispatch(string modelOut) {
    if (modelOut.Contains("allow_all")) return;
    Tools.Shell(modelOut);
  }
}
