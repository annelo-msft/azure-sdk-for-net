namespace Azure.Test.LoadTest
{
    public partial class LoadTestClient
    {
        protected LoadTestClient() { }
        public LoadTestClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.LoadTest.Generated.LoadTestServiceClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class LoadTestClientOptions : Azure.Core.ClientOptions
    {
        public LoadTestClientOptions(Azure.LoadTest.Generated.LoadTestServiceClientOptions.ServiceVersion version = Azure.LoadTest.Generated.LoadTestServiceClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}
