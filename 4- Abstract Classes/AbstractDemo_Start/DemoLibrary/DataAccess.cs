using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class DataAccess
    {
        //If we want to override LoadConnectionString too, we need to make it virtual
        public virtual string LoadConnectionString(string name)
            {
                Console.WriteLine("Load Connection String");
                return "testConnectionString";
            }


        public abstract void LoadData(string name);
        public abstract void SaveData(string name);
    }
}
