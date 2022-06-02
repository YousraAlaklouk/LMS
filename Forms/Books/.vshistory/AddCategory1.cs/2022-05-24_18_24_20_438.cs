using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManegement.Forms.Books
{
    internal class AddCategory1
    {
        [BsonId]

        public string Category { get; set; }
        public string CreatedBy { get; set; }
    }
}
