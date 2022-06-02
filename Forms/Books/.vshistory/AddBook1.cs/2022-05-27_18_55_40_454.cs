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
        public ObjectId Id { get; set; }
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string AUTHOR_ID { get; set; }
        public int PUBLISHER_ID  { get; set; }
        public string CAT_ID { get; set; }

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
