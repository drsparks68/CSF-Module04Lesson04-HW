using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF_Module04Lesson04_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: Create a class that has properties for street address, city state and zip code.  Then add a FullAddress property that is read-only.

        Address myAddress = new Address();

        myAddress.StreetName = "35th Ave S";
        myAddress.HouseNumber = "7732";
        myAddress.Apartment = "";
        myAddress.City = "Anchorage";
        myAddress.State = "AK";
        myAddress.ZipCode = 12121;
        myAddress.ZipPlusFour = 8888;

            Console.WriteLine(myAddress.FullAddress);

        Console.ReadLine();
        }
    }
}
