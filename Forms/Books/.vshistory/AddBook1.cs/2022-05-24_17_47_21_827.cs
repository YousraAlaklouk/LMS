using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManegement.Forms.Books
{
    internal class AddBook1
    {
        [BsonId]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }

        public string ISBN { get; set; }
        public int Quantity { get; set; }

        public string Edition { get; set; }
        public string Editor { get; set; }
        public string Language { get; set; }

        public int PageCount { get; set; }
        public DateTime Publish { get; set; }

        public int Rate { get; set; }
/*        public string Cover { get; set; }*/

    }
}
