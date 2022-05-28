using System;

namespace PrivateServices.NetCore.Console.Attributes
{
    /// <summary>
    ///     Аттрибут указывающий, какое свойство может изменять пользователь с определенной ролью
    /// </summary>
    internal class EditSecurityAttribute : SecurityAttribute
    {
        public EditSecurityAttribute(string minimumRole)
        {
            MinimumRole = minimumRole;
        }

        public string MinimumRole { get; }
    }
}
