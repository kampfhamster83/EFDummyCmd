using System;

namespace EFDummyCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFDummyDbContext())
            {
                var p1 = new Person();
                p1.Firstname = "Peter";
                p1.Lastname = "Schmidt";
                context.Persons.Add(p1);
                context.SaveChanges();
                Console.WriteLine("Eintrag hinzugefügt");
            }
        }
    }
}
