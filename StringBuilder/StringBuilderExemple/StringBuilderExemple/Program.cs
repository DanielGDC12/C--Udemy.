using System;
using StringBuilderExemple.Entities;

namespace StringBuilderExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("What a awesome notice!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:45:56"),
                "Traveling across the world",
                165,
                "Im going to Brazil right now"
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}
