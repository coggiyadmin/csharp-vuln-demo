public class Llm03TrainingDataPoison {
  public void Ingest(string untrusted) { Corpus.Add(untrusted); } // unfiltered train ingest
  static readonly System.Collections.Generic.List<string> Corpus = new();
}
