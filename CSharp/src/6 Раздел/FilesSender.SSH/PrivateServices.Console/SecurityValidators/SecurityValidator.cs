namespace PrivateServices.Console.SecurityValidators
{
    internal abstract class SecurityValidator<TEntity>
    {
        private readonly List<string> _errors = new List<string>();

        public IEnumerable<string> Errors => _errors;

        public abstract bool IsSecured(TEntity entityToSecure);
    }
}
