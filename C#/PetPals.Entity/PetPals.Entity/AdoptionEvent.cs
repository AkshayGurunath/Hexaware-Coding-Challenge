using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    public class AdoptionEvent
    {
        public List<IAdoptable> Participants { get; set; }

        public AdoptionEvent()
        {
            Participants = new List<IAdoptable>();
        }
    }
}
