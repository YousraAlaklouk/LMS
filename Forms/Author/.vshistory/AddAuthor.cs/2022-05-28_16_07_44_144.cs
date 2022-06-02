using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LibraryManegement.Forms.Author
{
    [BsonIgnoreExtraElements]
    internal class AddAuthor
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }

        public string NATIONALITY { get; set; }
        public string EMAIL { get; set; }

    }
}
