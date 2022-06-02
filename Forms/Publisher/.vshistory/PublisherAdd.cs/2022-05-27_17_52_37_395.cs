﻿using System;
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
        public  ObjectId Id {get; set; }
        public int ID { get; set; }

        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public int FOUNDATION_YEAR { get; set; }
        public string EMAIL { get; set; }
    }
}