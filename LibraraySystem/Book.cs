using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Book
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
        public string IsDeleted { get; set; }

        public Book(string title, string author, string description, string genre, string status, string isDeleted)
        {
            Title = title;
            Author = author;
            Description = description;
            Genre = genre;
            Status = "A";
            IsDeleted = "N";
        }
    }
}
