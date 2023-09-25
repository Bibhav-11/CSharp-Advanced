using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract classes: Try to only use a is-a relationship or parent child relationship. Don't just inherit something just because it shares common properties. Eg. Dont try to fit truck in a car class. Use interface in that context since interface is implemented not inherited.

namespace ConsoleUI
{
    class Program

    {
        static void Main(string[] args)
        {

            List<DataAccess> data = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess(),
            };

            foreach(var db in data)
            {
                Console.WriteLine(db.LoadConnectionString("test"));
                db.LoadData("Select * from table");
                db.SaveData("Insert into table");
                Console.WriteLine();
            }


            //List<IDataAccess> databases = new List<IDataAccess>()
            //{
            //    new SqlDataAccess(),
            //    new SqliteDataAccess()
            //};

            //foreach (var db in databases)
            //{
            //    db.LoadConnectionString("demo");
            //    db.LoadData("select * from table");
            //    db.SaveData("insert into table");
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
