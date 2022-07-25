namespace SecuredServices.Core
{
    public interface IManagerSession<TId>
    {
        void AuthorizeById(TId id);
        public bool IsAuthorized { get; }
        public string Role { get; }

    }
}
