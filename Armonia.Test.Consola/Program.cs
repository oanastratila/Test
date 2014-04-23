using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armonia.Ambulator.Model;
using Armonia.Ambulator.Model.Nomenclatoare;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClinicContext())
            {
                Console.WriteLine("Introduceti codul tarii: ");
                var codTara = Console.ReadLine();

                Console.WriteLine("Introduceti numele tarii: ");
                var numeTara = Console.ReadLine();

                /*var country = new NomCountry();
                country.Name = numeTara;
                country.Code = codTara;
                 varianta clasica*/

                var countryNew = new NomCountry { Name = numeTara, Code = codTara };


                context.Countries.Add(countryNew);
                context.SaveChanges();

            }
        }
    }
}
