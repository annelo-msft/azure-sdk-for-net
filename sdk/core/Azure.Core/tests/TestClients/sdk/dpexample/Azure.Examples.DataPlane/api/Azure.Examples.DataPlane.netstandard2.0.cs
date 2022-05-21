namespace Azure.Examples.DataPlane
{
    public partial class DataPlaneClient
    {
        protected DataPlaneClient() { }
        public DataPlaneClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Examples.DataPlane.DataPlaneClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class DataPlaneClientOptions : Azure.Core.ClientOptions
    {
        public DataPlaneClientOptions(Azure.Examples.DataPlane.Generated.DataPlaneClientOptions.ServiceVersion version = Azure.Examples.DataPlane.Generated.DataPlaneClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}