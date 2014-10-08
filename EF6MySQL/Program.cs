using System;
using System.Linq;
using System.Collections.Generic;

namespace EF6MySQL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            using (var db = new MyModelContext())
            {
                db.MyModel.Add(new MyModel { Value = "Hello MySQL!" });
                db.SaveChanges();

                List<MyModel> list = db.MyModel.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine(item.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
