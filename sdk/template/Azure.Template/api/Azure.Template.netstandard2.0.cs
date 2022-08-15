namespace Azure.Template
{
    public partial class ConfidentialLedgerClient
    {
        protected ConfidentialLedgerClient() { }
        public ConfidentialLedgerClient(Azure.Core.TokenCredential credential) { }
        public ConfidentialLedgerClient(Azure.Core.TokenCredential credential, Azure.Template.ConfidentialLedgerClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response CreateOrUpdateUser(string ledgerUri, string userId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateUserAsync(string ledgerUri, string userId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteUser(string ledgerUri, string userId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteUserAsync(string ledgerUri, string userId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetCollections(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCollectionsAsync(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetConsortiumMembers(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetConsortiumMembersAsync(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetConstitution(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetConstitutionAsync(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetCurrentLedgerEntry(string ledgerUri, string collectionId = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCurrentLedgerEntryAsync(string ledgerUri, string collectionId = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEnclaveQuotes(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEnclaveQuotesAsync(string ledgerUri, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetLedgerEntry(string ledgerUri, string transactionId, string collectionId = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetLedgerEntryAsync(string ledgerUri, string transactionId, string collectionId = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetReceipt(string ledgerUri, string transactionId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetReceiptAsync(string ledgerUri, string transactionId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTransactionStatus(string ledgerUri, string transactionId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTransactionStatusAsync(string ledgerUri, string transactionId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetUser(string ledgerUri, string userId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUserAsync(string ledgerUri, string userId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PostLedgerEntry(string ledgerUri, Azure.Core.RequestContent content, string collectionId = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PostLedgerEntryAsync(string ledgerUri, Azure.Core.RequestContent content, string collectionId = null, Azure.RequestContext context = null) { throw null; }
    }
    public partial class ConfidentialLedgerClientOptions : Azure.Core.ClientOptions
    {
        public ConfidentialLedgerClientOptions(Azure.Template.ConfidentialLedgerClientOptions.ServiceVersion version = Azure.Template.ConfidentialLedgerClientOptions.ServiceVersion.V2022_05_13) { }
        public enum ServiceVersion
        {
            V2022_05_13 = 1,
        }
    }
}
