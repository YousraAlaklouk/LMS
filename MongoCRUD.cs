using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManegement
{
    public class MongoCRUD
    {

        private IMongoDatabase db;

        public MongoCRUD(string database)
        {

            var client = new MongoClient("mongodb+srv://sami:123123123@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");
            db = client.GetDatabase(database);

        }


        // add one record 
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
        // load record
        public List<T> LoadRecord<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();

        }
        //load record by ID
        public T loadRecordById<T>(string table, ObjectId id)
        {
            var collections = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            return collections.Find(filter).First();
        }

        //Update record
        public void UpdateRecord<T>(string table, ObjectId id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record //,
                       //new UpdateOptions { IsUpsert = true }
                );
        }
        //delete record
        public void DeleteRecord<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);

        }

    }
}