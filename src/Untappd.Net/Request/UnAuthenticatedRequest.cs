namespace Untappd.Net.Request
{
    public abstract class UnAuthenticatedRequest : AuthenticatedRequest
    {
        protected override abstract string _EndPoint { get; }

    }
}
