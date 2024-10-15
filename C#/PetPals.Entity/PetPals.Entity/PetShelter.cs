using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    public class PetShelter
    {
        public List<Pet> AvailablePets { get; set; }

        public  string Name { get; set; }   

        public string Location { get; set; }

        public PetShelter()
        {
            AvailablePets = new List<Pet>();
        }
    }
}
