namespace Untappd.Net.Client
{
    public interface IAuthenticatedUntappdCredentials : IUntappdCredentials
    {
        string AccessToken { get; }
    }
}
