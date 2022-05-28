namespace SecuredServices.Core.Protectors
{
    public interface IEntityProtector<TEntity>
    {
        bool IsProtected(TEntity toCheck, TEntity initial);
        bool IsProtected(TEntity toCheck);
    }
}
