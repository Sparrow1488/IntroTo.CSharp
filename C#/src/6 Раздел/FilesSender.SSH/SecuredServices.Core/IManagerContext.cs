namespace SecuredServices.Core
{
    public interface IManagerContext<TId>
    {
        void AuthorizeById(TId id);
        public bool IsAuthorized { get; }
        public string Role { get; }

    }
}
