using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LibraryManegement.Forms.Author
{
    internal class AddAuthor
    {
        [BsonId]
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }

        public string Nationality { get; set; }
        public string Email{ get; set; }

    }
}
