using System;
using System.Collections.Generic;

namespace EF_Core_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            SalonDbContext db = new SalonDbContext();

            foreach (var item in db.Categories)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
