
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManegement.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManegement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }                
    }
    public class MongoCRUD 
    {
        //create - read - update -delted
        private IMongoDatabase db;

        public MongoCRUD(string databse)
        {
            var client = new MongoClient();
            db = client.GetDatabase(databse);

        }
        


    }

}
