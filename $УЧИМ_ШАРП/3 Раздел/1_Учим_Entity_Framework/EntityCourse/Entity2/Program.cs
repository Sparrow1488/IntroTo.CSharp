using System;

namespace Entity2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void AddAdmin()
        {
            using (AdminContext db = new AdminContext())
            {
                var admin = new Admin() { Role = "administrator", Name = "Valya" };
                db.Admin.Add(admin);
                db.SaveChanges();
                Console.WriteLine(admin.Name + " was insert");
            }
        }
        public static void AddUser()
        {
            using (UserContext db = new UserContext())
            {
                var user = new User() { Name = "VTUFUGFU", LastName = "ЧЕЛ" };
                db.Users.Add(user);
                db.SaveChanges();
                foreach (var item in db.Users)
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                var findUser = db.Users.Find(2);
                Console.WriteLine(findUser.Name);
            }
        }
    }
}
