using System;

namespace UndergroundProject.Domain.Enteties
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}
