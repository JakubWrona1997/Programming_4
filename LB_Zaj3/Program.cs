using System;
using System.Linq;

namespace Zaj3
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Kontekst();
            db.Database.EnsureCreated();
            db.Zajecia.Add(new Zajecia()
            { Id = 1, Name = "P4", Times = new DateTime(1, 1, 2020, 13, 30, 00) });
            db.SaveChanges();
            var zajecia = db.Zajecia.Where(x => x.Id > 2);

            foreach (var item in zajecia)
            {
                Console.WriteLine( $"{item.Id}. {item.Name} {item.Times.ToShortTimeString()}");

            }
            var zajeciaDoZmiany = db.Zajecia.First(x => x.Name.StartsWith("P"));
            zajeciaDoZmiany.Name = "AM2";
            db.Update(zajeciaDoZmiany);
            db.SaveChanges();
        }
    }
}
