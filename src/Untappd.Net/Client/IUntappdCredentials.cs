namespace Untappd.Net.Client
{
    public interface IUntappdCredentials
    {
        string ClientId { get; }
        string ClientSecret { get; }
    }
}
