using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManegement.Forms.Books
{
    [BsonIgnoreExtraElements]
    internal class AddCategory1
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int ID { get; set; }
        public string CATEGORY { get; set; }
        public string CREATED_BY { get; set; }
    }
}
