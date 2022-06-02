using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManegement.Forms.Publisher
{
    internal class PublisherAdd
    {
        [BsonId]
        public string objectId id 
        public string PublisherName { get; set; }
        public string Email { get; set; }
        public string Year { get; set; }
        public string Address { get; set; }
    }
}
