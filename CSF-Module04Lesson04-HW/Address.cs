using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF_Module04Lesson04_HW
{
    public class Address
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int ZipPlusFour { get; set; }

        public string FullAddress
        {
            get 
            {
                return $"{ HouseNumber } { StreetName } { City }, { State } { ZipCode }+{ ZipPlusFour } ";
            }
        }

    }
}
