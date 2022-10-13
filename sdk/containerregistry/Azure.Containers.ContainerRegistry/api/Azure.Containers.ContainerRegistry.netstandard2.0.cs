namespace Azure.Containers.ContainerRegistry
{
    public partial class AcrAccessToken
    {
        internal AcrAccessToken() { }
        public string AccessToken { get { throw null; } }
    }
    public partial class AcrRefreshToken
    {
        internal AcrRefreshToken() { }
        public string RefreshToken { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactArchitecture : System.IEquatable<Azure.Containers.ContainerRegistry.ArtifactArchitecture>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactArchitecture(string value) { throw null; }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Amd64 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Arm { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Arm64 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture I386 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Mips { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Mips64 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Mips64Le { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture MipsLe { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Ppc64 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Ppc64Le { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture RiscV64 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture S390X { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactArchitecture Wasm { get { throw null; } }
        public bool Equals(Azure.Containers.ContainerRegistry.ArtifactArchitecture other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Containers.ContainerRegistry.ArtifactArchitecture left, Azure.Containers.ContainerRegistry.ArtifactArchitecture right) { throw null; }
        public static implicit operator Azure.Containers.ContainerRegistry.ArtifactArchitecture (string value) { throw null; }
        public static bool operator !=(Azure.Containers.ContainerRegistry.ArtifactArchitecture left, Azure.Containers.ContainerRegistry.ArtifactArchitecture right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArtifactDownloadToOptions
    {
        public ArtifactDownloadToOptions() { }
        public int? MaxConcurrency { get { throw null; } set { } }
        public long? MaxDownloadSize { get { throw null; } set { } }
    }
    public enum ArtifactManifestOrder
    {
        None = 0,
        LastUpdatedOnDescending = 1,
        LastUpdatedOnAscending = 2,
    }
    public partial class ArtifactManifestPlatform
    {
        internal ArtifactManifestPlatform() { }
        public Azure.Containers.ContainerRegistry.ArtifactArchitecture? Architecture { get { throw null; } }
        public string Digest { get { throw null; } }
        public Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? OperatingSystem { get { throw null; } }
    }
    public partial class ArtifactManifestProperties
    {
        public ArtifactManifestProperties() { }
        public Azure.Containers.ContainerRegistry.ArtifactArchitecture? Architecture { get { throw null; } }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
        public System.DateTimeOffset CreatedOn { get { throw null; } }
        public string Digest { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? OperatingSystem { get { throw null; } }
        public string RegistryLoginServer { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ArtifactManifestPlatform> RelatedArtifacts { get { throw null; } }
        public string RepositoryName { get { throw null; } }
        public long? SizeInBytes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Tags { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactOperatingSystem : System.IEquatable<Azure.Containers.ContainerRegistry.ArtifactOperatingSystem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactOperatingSystem(string value) { throw null; }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Aix { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Android { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Darwin { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Dragonfly { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem FreeBsd { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Illumos { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem iOS { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem JS { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Linux { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem NetBsd { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem OpenBsd { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Plan9 { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Solaris { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ArtifactOperatingSystem Windows { get { throw null; } }
        public bool Equals(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem left, Azure.Containers.ContainerRegistry.ArtifactOperatingSystem right) { throw null; }
        public static implicit operator Azure.Containers.ContainerRegistry.ArtifactOperatingSystem (string value) { throw null; }
        public static bool operator !=(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem left, Azure.Containers.ContainerRegistry.ArtifactOperatingSystem right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArtifactStreams
    {
        public ArtifactStreams() { }
        public System.IO.Stream Config { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.IO.Stream> Layers { get { throw null; } }
        public System.IO.Stream Manifest { get { throw null; } set { } }
    }
    public enum ArtifactTagOrder
    {
        None = 0,
        LastUpdatedOnDescending = 1,
        LastUpdatedOnAscending = 2,
    }
    public partial class ArtifactTagProperties
    {
        public ArtifactTagProperties() { }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
        public System.DateTimeOffset CreatedOn { get { throw null; } }
        public string Digest { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public string Name { get { throw null; } }
        public string RegistryLoginServer { get { throw null; } }
        public string RepositoryName { get { throw null; } }
    }
    public partial class ArtifactUploadInfo
    {
        public ArtifactUploadInfo() { }
    }
    public partial class ArtifactUploadOptions
    {
        public ArtifactUploadOptions() { }
        public int? MaxConcurrency { get { throw null; } set { } }
        public long? MaxUploadSize { get { throw null; } set { } }
    }
    public partial class AuthenticationClient
    {
        protected AuthenticationClient() { }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.AcrRefreshToken> ExchangeAadAccessTokenForAcrRefreshToken(Azure.Containers.ContainerRegistry.PostContentSchemaGrantType grantType, string service, string tenant = null, string refreshToken = null, string accessToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.AcrRefreshToken>> ExchangeAadAccessTokenForAcrRefreshTokenAsync(Azure.Containers.ContainerRegistry.PostContentSchemaGrantType grantType, string service, string tenant = null, string refreshToken = null, string accessToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.AcrAccessToken> ExchangeAcrRefreshTokenForAcrAccessToken(string service, string scope, string refreshToken, Azure.Containers.ContainerRegistry.TokenGrantType grantType = Azure.Containers.ContainerRegistry.TokenGrantType.RefreshToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.AcrAccessToken>> ExchangeAcrRefreshTokenForAcrAccessTokenAsync(string service, string scope, string refreshToken, Azure.Containers.ContainerRegistry.TokenGrantType grantType = Azure.Containers.ContainerRegistry.TokenGrantType.RefreshToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryAudience : System.IEquatable<Azure.Containers.ContainerRegistry.ContainerRegistryAudience>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryAudience(string value) { throw null; }
        public static Azure.Containers.ContainerRegistry.ContainerRegistryAudience AzureResourceManagerChina { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ContainerRegistryAudience AzureResourceManagerGermany { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ContainerRegistryAudience AzureResourceManagerGovernment { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.ContainerRegistryAudience AzureResourceManagerPublicCloud { get { throw null; } }
        public bool Equals(Azure.Containers.ContainerRegistry.ContainerRegistryAudience other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Containers.ContainerRegistry.ContainerRegistryAudience left, Azure.Containers.ContainerRegistry.ContainerRegistryAudience right) { throw null; }
        public static implicit operator Azure.Containers.ContainerRegistry.ContainerRegistryAudience (string value) { throw null; }
        public static bool operator !=(Azure.Containers.ContainerRegistry.ContainerRegistryAudience left, Azure.Containers.ContainerRegistry.ContainerRegistryAudience right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryClient
    {
        protected ContainerRegistryClient() { }
        public ContainerRegistryClient(System.Uri endpoint) { }
        public ContainerRegistryClient(System.Uri endpoint, Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions options) { }
        public ContainerRegistryClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public ContainerRegistryClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions options) { }
        public virtual System.Uri Endpoint { get { throw null; } }
        public virtual Azure.Response CheckDockerV2Support(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CheckDockerV2SupportAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateManifest(string name, string reference, System.IO.Stream payload, string contentType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateManifestAsync(string name, string reference, System.IO.Stream payload, string contentType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteManifest(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteManifestAsync(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteRepository(string repositoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteRepositoryAsync(string repositoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteTag(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTagAsync(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Containers.ContainerRegistry.RegistryArtifact GetArtifact(string repositoryName, string tagOrDigest) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ManifestWrapper> GetManifest(string name, string reference, string accept = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ManifestWrapper>> GetManifestAsync(string name, string reference, string accept = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> GetManifestProperties(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties>> GetManifestPropertiesAsync(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Containers.ContainerRegistry.ManifestAttributesBase> GetManifests(string name, string last = null, int? n = default(int?), string orderby = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Containers.ContainerRegistry.ManifestAttributesBase> GetManifestsAsync(string name, string last = null, int? n = default(int?), string orderby = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties> GetProperties(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties>> GetPropertiesAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetRepositories(string last = null, int? n = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetRepositoriesAsync(string last = null, int? n = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Containers.ContainerRegistry.ContainerRepository GetRepository(string repositoryName) { throw null; }
        public virtual Azure.Pageable<string> GetRepositoryNames(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetRepositoryNamesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetTagProperties(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties>> GetTagPropertiesAsync(string name, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Containers.ContainerRegistry.TagAttributesBase> GetTags(string name, string last = null, int? n = default(int?), string orderby = null, string digest = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Containers.ContainerRegistry.TagAttributesBase> GetTagsAsync(string name, string last = null, int? n = default(int?), string orderby = null, string digest = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> UpdateManifestProperties(string name, string digest, Azure.Containers.ContainerRegistry.ManifestWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties>> UpdateManifestPropertiesAsync(string name, string digest, Azure.Containers.ContainerRegistry.ManifestWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties> UpdateProperties(string name, Azure.Containers.ContainerRegistry.RepositoryWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties>> UpdatePropertiesAsync(string name, Azure.Containers.ContainerRegistry.RepositoryWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties> UpdateTagAttributes(string name, string reference, Azure.Containers.ContainerRegistry.TagWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties>> UpdateTagAttributesAsync(string name, string reference, Azure.Containers.ContainerRegistry.TagWriteableProperties value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRegistryClientOptions : Azure.Core.ClientOptions
    {
        public ContainerRegistryClientOptions(Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions.ServiceVersion version = Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions.ServiceVersion.V2021_07_01) { }
        public Azure.Containers.ContainerRegistry.ContainerRegistryAudience? Audience { get { throw null; } set { } }
        public enum ServiceVersion
        {
            V2021_07_01 = 1,
        }
    }
    public static partial class ContainerRegistryModelFactory
    {
        public static Azure.Containers.ContainerRegistry.AcrAccessToken AcrAccessToken(string accessToken = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.AcrRefreshToken AcrRefreshToken(string refreshToken = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.ArtifactManifestPlatform ArtifactManifestPlatform(string digest = null, Azure.Containers.ContainerRegistry.ArtifactArchitecture? architecture = default(Azure.Containers.ContainerRegistry.ArtifactArchitecture?), Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? operatingSystem = default(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.ArtifactManifestProperties ArtifactManifestProperties(string registryLoginServer = null, string repositoryName = null, string digest = null, long? sizeInBytes = default(long?), System.DateTimeOffset createdOn = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), Azure.Containers.ContainerRegistry.ArtifactArchitecture? architecture = default(Azure.Containers.ContainerRegistry.ArtifactArchitecture?), Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? operatingSystem = default(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem?), System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ArtifactManifestPlatform> relatedArtifacts = null, System.Collections.Generic.IEnumerable<string> tags = null, bool? canDelete = default(bool?), bool? canWrite = default(bool?), bool? canList = default(bool?), bool? canRead = default(bool?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.ArtifactTagProperties ArtifactTagProperties(string registryLoginServer = null, string repositoryName = null, string name = null, string digest = null, System.DateTimeOffset createdOn = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), bool? canDelete = default(bool?), bool? canWrite = default(bool?), bool? canList = default(bool?), bool? canRead = default(bool?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.ContainerRepositoryProperties ContainerRepositoryProperties(string registryLoginServer = null, string name = null, System.DateTimeOffset createdOn = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), int manifestCount = 0, int tagCount = 0, bool? canDelete = default(bool?), bool? canWrite = default(bool?), bool? canList = default(bool?), bool? canRead = default(bool?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.Specialized.DownloadBlobResult DownloadBlobResult(string digest = null, System.IO.Stream content = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.Specialized.DownloadManifestResult DownloadManifestResult(string digest = null, Azure.Containers.ContainerRegistry.Specialized.OciManifest manifest = null, System.IO.Stream manifestStream = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.FsLayer FsLayer(string blobSum = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.History History(string v1Compatibility = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.ImageSignature ImageSignature(Azure.Containers.ContainerRegistry.JWK header = null, string signature = null, string @protected = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.JWK JWK(Azure.Containers.ContainerRegistry.JWKHeader jwk = null, string alg = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.JWKHeader JWKHeader(string crv = null, string kid = null, string kty = null, string x = null, string y = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.Manifest Manifest(int? schemaVersion = default(int?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.ManifestAttributesBase ManifestAttributesBase(string digest = null, long? size = default(long?), System.DateTimeOffset createdOn = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), Azure.Containers.ContainerRegistry.ArtifactArchitecture? architecture = default(Azure.Containers.ContainerRegistry.ArtifactArchitecture?), Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? operatingSystem = default(Azure.Containers.ContainerRegistry.ArtifactOperatingSystem?), System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ArtifactManifestPlatform> relatedArtifacts = null, System.Collections.Generic.IEnumerable<string> tags = null, bool? canDelete = default(bool?), bool? canWrite = default(bool?), bool? canList = default(bool?), bool? canRead = default(bool?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.ManifestList ManifestList(int? schemaVersion = default(int?), string mediaType = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ManifestListAttributes> manifests = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.ManifestListAttributes ManifestListAttributes(string mediaType = null, long? size = default(long?), string digest = null, Azure.Containers.ContainerRegistry.Platform platform = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.ManifestWrapper ManifestWrapper(int? schemaVersion = default(int?), string mediaType = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ManifestListAttributes> manifests = null, Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor config = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor> layers = null, Azure.Containers.ContainerRegistry.Specialized.OciAnnotations annotations = null, string architecture = null, string name = null, string tag = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.FsLayer> fsLayers = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.History> history = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ImageSignature> signatures = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.OCIIndex OCIIndex(int? schemaVersion = default(int?), System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ManifestListAttributes> manifests = null, Azure.Containers.ContainerRegistry.Specialized.OciAnnotations annotations = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.Platform Platform(string architecture = null, string os = null, string osVersion = null, System.Collections.Generic.IEnumerable<string> osFeatures = null, string variant = null, System.Collections.Generic.IEnumerable<string> features = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.TagAttributesBase TagAttributesBase(string name = null, string digest = null, System.DateTimeOffset createdOn = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), bool? canDelete = default(bool?), bool? canWrite = default(bool?), bool? canList = default(bool?), bool? canRead = default(bool?)) { throw null; }
        public static Azure.Containers.ContainerRegistry.Specialized.UploadBlobResult UploadBlobResult(string digest = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.Specialized.UploadManifestResult UploadManifestResult(string digest = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.V1Manifest V1Manifest(int? schemaVersion = default(int?), string architecture = null, string name = null, string tag = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.FsLayer> fsLayers = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.History> history = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.ImageSignature> signatures = null) { throw null; }
        public static Azure.Containers.ContainerRegistry.V2Manifest V2Manifest(int? schemaVersion = default(int?), string mediaType = null, Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor config = null, System.Collections.Generic.IEnumerable<Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor> layers = null) { throw null; }
    }
    public partial class ContainerRepository
    {
        protected ContainerRepository() { }
        public virtual string Name { get { throw null; } }
        public virtual System.Uri RegistryEndpoint { get { throw null; } }
        public virtual Azure.Response Delete(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> GetAllManifestProperties(Azure.Containers.ContainerRegistry.ArtifactManifestOrder manifestOrder = Azure.Containers.ContainerRegistry.ArtifactManifestOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> GetAllManifestPropertiesAsync(Azure.Containers.ContainerRegistry.ArtifactManifestOrder manifestOrder = Azure.Containers.ContainerRegistry.ArtifactManifestOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Containers.ContainerRegistry.RegistryArtifact GetArtifact(string tagOrDigest) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties> GetProperties(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties>> GetPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties> UpdateProperties(Azure.Containers.ContainerRegistry.ContainerRepositoryProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ContainerRepositoryProperties>> UpdatePropertiesAsync(Azure.Containers.ContainerRegistry.ContainerRepositoryProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRepositoryProperties
    {
        public ContainerRepositoryProperties() { }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
        public System.DateTimeOffset CreatedOn { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public int ManifestCount { get { throw null; } }
        public string Name { get { throw null; } }
        public string RegistryLoginServer { get { throw null; } }
        public int TagCount { get { throw null; } }
    }
    public partial class FsLayer
    {
        internal FsLayer() { }
        public string BlobSum { get { throw null; } }
    }
    public partial class History
    {
        internal History() { }
        public string V1Compatibility { get { throw null; } }
    }
    public partial class ImageSignature
    {
        internal ImageSignature() { }
        public Azure.Containers.ContainerRegistry.JWK Header { get { throw null; } }
        public string Protected { get { throw null; } }
        public string Signature { get { throw null; } }
    }
    public partial class JWK
    {
        internal JWK() { }
        public string Alg { get { throw null; } }
        public Azure.Containers.ContainerRegistry.JWKHeader Jwk { get { throw null; } }
    }
    public partial class JWKHeader
    {
        internal JWKHeader() { }
        public string Crv { get { throw null; } }
        public string Kid { get { throw null; } }
        public string Kty { get { throw null; } }
        public string X { get { throw null; } }
        public string Y { get { throw null; } }
    }
    public partial class Manifest
    {
        internal Manifest() { }
        public int? SchemaVersion { get { throw null; } }
    }
    public partial class ManifestAttributesBase
    {
        internal ManifestAttributesBase() { }
        public Azure.Containers.ContainerRegistry.ArtifactArchitecture? Architecture { get { throw null; } }
        public bool? CanDelete { get { throw null; } }
        public bool? CanList { get { throw null; } }
        public bool? CanRead { get { throw null; } }
        public bool? CanWrite { get { throw null; } }
        public System.DateTimeOffset CreatedOn { get { throw null; } }
        public string Digest { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public Azure.Containers.ContainerRegistry.ArtifactOperatingSystem? OperatingSystem { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ArtifactManifestPlatform> RelatedArtifacts { get { throw null; } }
        public long? Size { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Tags { get { throw null; } }
    }
    public partial class ManifestList : Azure.Containers.ContainerRegistry.Manifest
    {
        internal ManifestList() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ManifestListAttributes> Manifests { get { throw null; } }
        public string MediaType { get { throw null; } }
    }
    public partial class ManifestListAttributes
    {
        internal ManifestListAttributes() { }
        public string Digest { get { throw null; } }
        public string MediaType { get { throw null; } }
        public Azure.Containers.ContainerRegistry.Platform Platform { get { throw null; } }
        public long? Size { get { throw null; } }
    }
    public partial class ManifestWrapper : Azure.Containers.ContainerRegistry.Manifest
    {
        internal ManifestWrapper() { }
        public Azure.Containers.ContainerRegistry.Specialized.OciAnnotations Annotations { get { throw null; } }
        public string Architecture { get { throw null; } }
        public Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor Config { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.FsLayer> FsLayers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.History> History { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor> Layers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ManifestListAttributes> Manifests { get { throw null; } }
        public string MediaType { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ImageSignature> Signatures { get { throw null; } }
        public string Tag { get { throw null; } }
    }
    public partial class ManifestWriteableProperties
    {
        public ManifestWriteableProperties() { }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
    }
    public partial class OCIIndex : Azure.Containers.ContainerRegistry.Manifest
    {
        internal OCIIndex() { }
        public Azure.Containers.ContainerRegistry.Specialized.OciAnnotations Annotations { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ManifestListAttributes> Manifests { get { throw null; } }
    }
    public partial class Platform
    {
        internal Platform() { }
        public string Architecture { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Features { get { throw null; } }
        public string Os { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> OsFeatures { get { throw null; } }
        public string OsVersion { get { throw null; } }
        public string Variant { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PostContentSchemaGrantType : System.IEquatable<Azure.Containers.ContainerRegistry.PostContentSchemaGrantType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PostContentSchemaGrantType(string value) { throw null; }
        public static Azure.Containers.ContainerRegistry.PostContentSchemaGrantType AccessToken { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.PostContentSchemaGrantType AccessTokenRefreshToken { get { throw null; } }
        public static Azure.Containers.ContainerRegistry.PostContentSchemaGrantType RefreshToken { get { throw null; } }
        public bool Equals(Azure.Containers.ContainerRegistry.PostContentSchemaGrantType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Containers.ContainerRegistry.PostContentSchemaGrantType left, Azure.Containers.ContainerRegistry.PostContentSchemaGrantType right) { throw null; }
        public static implicit operator Azure.Containers.ContainerRegistry.PostContentSchemaGrantType (string value) { throw null; }
        public static bool operator !=(Azure.Containers.ContainerRegistry.PostContentSchemaGrantType left, Azure.Containers.ContainerRegistry.PostContentSchemaGrantType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RegistryArtifact
    {
        protected RegistryArtifact() { }
        public virtual string FullyQualifiedReference { get { throw null; } }
        public virtual System.Uri RegistryEndpoint { get { throw null; } }
        public virtual string RepositoryName { get { throw null; } }
        public virtual Azure.Response Delete(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteTag(string tag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTagAsync(string tag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DownloadTo(Azure.Containers.ContainerRegistry.ArtifactStreams destination, Azure.Containers.ContainerRegistry.ArtifactDownloadToOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DownloadTo(string path, Azure.Containers.ContainerRegistry.ArtifactDownloadToOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DownloadToAsync(Azure.Containers.ContainerRegistry.ArtifactStreams destination, Azure.Containers.ContainerRegistry.ArtifactDownloadToOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DownloadToAsync(string path, Azure.Containers.ContainerRegistry.ArtifactDownloadToOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetAllTagProperties(Azure.Containers.ContainerRegistry.ArtifactTagOrder tagOrder = Azure.Containers.ContainerRegistry.ArtifactTagOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetAllTagPropertiesAsync(Azure.Containers.ContainerRegistry.ArtifactTagOrder tagOrder = Azure.Containers.ContainerRegistry.ArtifactTagOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> GetManifestProperties(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties>> GetManifestPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetTagProperties(string tag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties>> GetTagPropertiesAsync(string tag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetTagPropertiesCollection(Azure.Containers.ContainerRegistry.ArtifactTagOrder orderBy = Azure.Containers.ContainerRegistry.ArtifactTagOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Containers.ContainerRegistry.ArtifactTagProperties> GetTagPropertiesCollectionAsync(Azure.Containers.ContainerRegistry.ArtifactTagOrder orderBy = Azure.Containers.ContainerRegistry.ArtifactTagOrder.None, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties> UpdateManifestProperties(Azure.Containers.ContainerRegistry.ArtifactManifestProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactManifestProperties>> UpdateManifestPropertiesAsync(Azure.Containers.ContainerRegistry.ArtifactManifestProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties> UpdateTagProperties(string tag, Azure.Containers.ContainerRegistry.ArtifactTagProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactTagProperties>> UpdateTagPropertiesAsync(string tag, Azure.Containers.ContainerRegistry.ArtifactTagProperties value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactUploadInfo> Upload(Azure.Containers.ContainerRegistry.ArtifactStreams content, Azure.Containers.ContainerRegistry.ArtifactUploadOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.ArtifactUploadInfo> Upload(string path, Azure.Containers.ContainerRegistry.ArtifactUploadOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactUploadInfo>> UploadAsync(Azure.Containers.ContainerRegistry.ArtifactStreams content, Azure.Containers.ContainerRegistry.ArtifactUploadOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.ArtifactUploadInfo>> UploadAsync(string path, Azure.Containers.ContainerRegistry.ArtifactUploadOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class RepositoryWriteableProperties
    {
        public RepositoryWriteableProperties() { }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
    }
    public partial class TagAttributesBase
    {
        internal TagAttributesBase() { }
        public bool? CanDelete { get { throw null; } }
        public bool? CanList { get { throw null; } }
        public bool? CanRead { get { throw null; } }
        public bool? CanWrite { get { throw null; } }
        public System.DateTimeOffset CreatedOn { get { throw null; } }
        public string Digest { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class TagWriteableProperties
    {
        public TagWriteableProperties() { }
        public bool? CanDelete { get { throw null; } set { } }
        public bool? CanList { get { throw null; } set { } }
        public bool? CanRead { get { throw null; } set { } }
        public bool? CanWrite { get { throw null; } set { } }
    }
    public enum TokenGrantType
    {
        RefreshToken = 0,
        Password = 1,
    }
    public partial class V1Manifest : Azure.Containers.ContainerRegistry.Manifest
    {
        internal V1Manifest() { }
        public string Architecture { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.FsLayer> FsLayers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.History> History { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.ImageSignature> Signatures { get { throw null; } }
        public string Tag { get { throw null; } }
    }
    public partial class V2Manifest : Azure.Containers.ContainerRegistry.Manifest
    {
        internal V2Manifest() { }
        public Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor Config { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor> Layers { get { throw null; } }
        public string MediaType { get { throw null; } }
    }
}
namespace Azure.Containers.ContainerRegistry.Specialized
{
    public partial class ContainerRegistryBlobClient
    {
        protected ContainerRegistryBlobClient() { }
        public ContainerRegistryBlobClient(System.Uri endpoint, Azure.Core.TokenCredential credential, string repository) { }
        public ContainerRegistryBlobClient(System.Uri endpoint, Azure.Core.TokenCredential credential, string repository, Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions options) { }
        public ContainerRegistryBlobClient(System.Uri endpoint, string repository) { }
        public ContainerRegistryBlobClient(System.Uri endpoint, string repository, Azure.Containers.ContainerRegistry.ContainerRegistryClientOptions options) { }
        public virtual System.Uri Endpoint { get { throw null; } }
        public virtual string RepositoryName { get { throw null; } }
        public virtual Azure.Response CancelUpload(string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CancelUploadAsync(string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CheckBlobExists(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CheckBlobExistsAsync(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CheckChunkExists(string name, string digest, string range, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CheckChunkExistsAsync(string name, string digest, string range, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CompleteUpload(string digest, string nextLink, System.IO.Stream value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CompleteUploadAsync(string digest, string nextLink, System.IO.Stream value = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> DeleteBlob(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteBlob(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> DeleteBlobAsync(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteBlobAsync(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteManifest(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteManifestAsync(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.Specialized.DownloadBlobResult> DownloadBlob(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.Specialized.DownloadBlobResult>> DownloadBlobAsync(string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.Specialized.DownloadManifestResult> DownloadManifest(Azure.Containers.ContainerRegistry.Specialized.DownloadManifestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.Specialized.DownloadManifestResult>> DownloadManifestAsync(Azure.Containers.ContainerRegistry.Specialized.DownloadManifestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetBlob(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetBlobAsync(string name, string digest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetChunk(string name, string digest, string range, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetChunkAsync(string name, string digest, string range, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetUploadStatus(string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUploadStatusAsync(string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response MountBlob(string name, string from, string mount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> MountBlobAsync(string name, string from, string mount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StartUpload(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StartUploadAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadBlobResult> UploadBlob(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadBlobResult>> UploadBlobAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UploadChunk(string nextLink, System.IO.Stream value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UploadChunkAsync(string nextLink, System.IO.Stream value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadManifestResult> UploadManifest(Azure.Containers.ContainerRegistry.Specialized.OciManifest manifest, Azure.Containers.ContainerRegistry.Specialized.UploadManifestOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadManifestResult> UploadManifest(System.IO.Stream manifestStream, Azure.Containers.ContainerRegistry.Specialized.UploadManifestOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadManifestResult>> UploadManifestAsync(Azure.Containers.ContainerRegistry.Specialized.OciManifest manifest, Azure.Containers.ContainerRegistry.Specialized.UploadManifestOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Containers.ContainerRegistry.Specialized.UploadManifestResult>> UploadManifestAsync(System.IO.Stream manifestStream, Azure.Containers.ContainerRegistry.Specialized.UploadManifestOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DownloadBlobResult : System.IDisposable
    {
        internal DownloadBlobResult() { }
        public System.IO.Stream Content { get { throw null; } }
        public string Digest { get { throw null; } }
        public void Dispose() { }
    }
    public partial class DownloadManifestOptions
    {
        public DownloadManifestOptions(string tag = null, string digest = null) { }
        public string Digest { get { throw null; } }
        public string Tag { get { throw null; } }
    }
    public partial class DownloadManifestResult : System.IDisposable
    {
        internal DownloadManifestResult() { }
        public string Digest { get { throw null; } }
        public Azure.Containers.ContainerRegistry.Specialized.OciManifest Manifest { get { throw null; } }
        public System.IO.Stream ManifestStream { get { throw null; } }
        public void Dispose() { }
    }
    public partial class OciAnnotations
    {
        public OciAnnotations() { }
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get { throw null; } }
        public string Authors { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Documentation { get { throw null; } set { } }
        public string Licenses { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Revision { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public string Vendor { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class OciBlobDescriptor
    {
        public OciBlobDescriptor() { }
        public Azure.Containers.ContainerRegistry.Specialized.OciAnnotations Annotations { get { throw null; } set { } }
        public string Digest { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public long? Size { get { throw null; } set { } }
        public static string TrimSha(string digest) { throw null; }
    }
    public partial class OciManifest
    {
        public OciManifest() { }
        public Azure.Containers.ContainerRegistry.Specialized.OciAnnotations Annotations { get { throw null; } }
        public Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor Config { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Containers.ContainerRegistry.Specialized.OciBlobDescriptor> Layers { get { throw null; } }
        public int? SchemaVersion { get { throw null; } set { } }
    }
    public partial class UploadBlobResult
    {
        internal UploadBlobResult() { }
        public string Digest { get { throw null; } }
    }
    public partial class UploadManifestOptions
    {
        public UploadManifestOptions(string tag = null) { }
        public string Tag { get { throw null; } }
    }
    public partial class UploadManifestResult
    {
        internal UploadManifestResult() { }
        public string Digest { get { throw null; } }
    }
}
