// SAFE — hardcoded_secrets: rely on the ambient AWS credential chain, holding no key material.
using Amazon.Runtime;
public class V05AwsKeySafe {
  public AWSCredentials Run() => FallbackCredentialsFactory.GetCredentials();
}
