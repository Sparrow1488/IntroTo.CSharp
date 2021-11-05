using Attribute_Reflecsion.Models;
using System;
using System.Linq;

namespace Attribute_Reflecsion
{
    public class Program
    {
        public const string UserName = " ";
        static void Main(string[] args)
        {
            #region TEST
            //var requestActionType = typeof(UploadPhoto);
            //var photoType = typeof(Photo);
            //var attributes = photoType.GetCustomAttributes(false);
            //foreach (var attr in attributes)
            //    Console.WriteLine("[Attribute] ToString(): " + attr);

            //var requestAttrs = requestActionType.GetCustomAttributes(false);
            //foreach (var item in requestAttrs)
            //    Console.WriteLine("Type: " + item);

            //#region ShowAllProperties
            //var props = photoType.GetProperties();
            //foreach (var prop in props)
            //{
            //    Console.WriteLine("[Prop] Name: {0};\t Type: {1}", prop.Name, prop.PropertyType);
            //    Console.Write("\t[Prop attributes]: ");
            //    foreach (var attr in prop.GetCustomAttributes(false))
            //        Console.Write(attr + " ");
            //    Console.WriteLine();
            //}
            //#endregion

            //#region ShowDescriptionPropertyType
            //string propName = "Description";
            //var photoProp = photoType.GetProperty(propName);
            //Console.WriteLine(propName + " type: " + photoProp?.PropertyType);
            //#endregion
            #endregion

            new Photo("my_photo", ".png");
            var type = typeof(Photo);
            var name = type.Name;
            var fullName =  type.FullName;
            var classAttrebutes = type.GetCustomAttributes(false);
            Console.WriteLine("Class name: {0}", name);
            Console.WriteLine("Class full name: {0}", fullName);
            if (classAttrebutes.Any(a => a.GetType() == typeof(UserInfoAttribute)))
            {
                foreach (var att in classAttrebutes)
                {
                    var attribute = att as UserInfoAttribute;
                    Console.WriteLine("User name: " + attribute.Name);
                    Console.WriteLine("User id: " + attribute.Id);
                }
            }
        }
    }
}
