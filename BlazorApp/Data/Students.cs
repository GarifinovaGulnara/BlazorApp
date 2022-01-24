using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace BlazorApp.Data
{
    public class Students
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Surname { get; set; }
        [BsonElement]
        public int Group { get; set; }

        static List<Students> student = new List<Students>();
        public static List<string> titles = new List<string>() { "Имя", "Фамилия", "Группа" };

        
        public Students(string name, string surname, int group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public static void AddToList(string name, string surname, int group)
        {
            Students std = new Students(name, surname, group);
            student.Add(std);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Student");
            var collection = db.GetCollection<Students>("student");
            collection.InsertOne(std);
        }



        public static List<Students> GetStudentInfo()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Student");
            var collection = db.GetCollection<Students>("student");
            var listStud = collection.Find(x=>true).ToList();

            return listStud;
        }
    }
}
