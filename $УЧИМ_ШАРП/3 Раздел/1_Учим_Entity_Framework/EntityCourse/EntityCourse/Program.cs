using System;
using System.Collections.Generic;

namespace EntityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
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
