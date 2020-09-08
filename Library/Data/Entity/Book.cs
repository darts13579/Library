using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Entity
{
    public class Book : Entity
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public int Count { get; set; }

        public int ReservedCount { get; set; }

        public int IssuedCount { get; set; }

        [NotMapped]
        public int FreeCount => Count - ReservedCount - IssuedCount;
    }
}