namespace SecuredServices.Core.Protectors
{
    public interface IEntityProtector<TEntity>
    {
        bool IsProtected(TEntity toProtect, TEntity baseTemplate);
    }
}
