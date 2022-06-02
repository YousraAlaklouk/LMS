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
    internal class AddBook1
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId ID { get; set; }
        public string TITLE { get; set; }
        public ObjectId AUTHOR_ID { get; set; }
        public ObjectId PUBLISHER_ID  { get; set; }
        public ObjectId CAT_ID { get; set; }

        public string ISBN_NO { get; set; }
        public int QUANTITY { get; set; }

        public string EDITION { get; set; }
        public string EDITORS { get; set; }
        public string LANGUAGE { get; set; }

        public int PAGECOUNT { get; set; }
        public string DATE{ get; set; }

        public int RATE { get; set; }
/*        public string Cover { get; set; }*/

    }
}
