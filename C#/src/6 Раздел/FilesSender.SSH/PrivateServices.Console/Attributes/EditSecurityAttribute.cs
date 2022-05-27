namespace PrivateServices.Console.Attributes
{
    /// <summary>
    ///     Аттрибут указывающий, какое свойство может изменять пользователь с определенной ролью
    /// </summary>
    internal class EditSecurityAttribute : Attribute
    {
        public EditSecurityAttribute(string minimumRole)
        {
            MinimumRole = minimumRole;
        }

        public string MinimumRole { get; }
    }
}
