using System;
using System.Collections.Generic;

namespace EntityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context1 = new MyDbContext())
            //{
            //    var holo = new Holo() { Name = "1212" };
            //    context1.Holos.Add(holo);
            //    context1.SaveChanges();

            //    foreach (var item in context1.Holos)
            //    {
            //        Console.WriteLine(item.Name);
            //    };
            //}

            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Gigi-Gaga_Group",
                    Year = 2001
                };
                context.Groups.Add(group); // заносим данные в кэш
                context.SaveChanges(); // из кэша переносим все данные в БД

                var songs = new List<Song>()
                {
                    new Song() { Name = "КАво и шО", GroupId = group.Id},
                    new Song() { Name = "Преключения шута", GroupId = group.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();
                Console.WriteLine($"Group: {group.Name}; Songs: ");
                foreach (var song in songs)
                    Console.Write(song.Name + " ");
            }
        }
    }
}
