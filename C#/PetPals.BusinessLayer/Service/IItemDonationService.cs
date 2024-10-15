using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Service
{
    public interface IItemDonationService
    {
        void RecordItemDonation(ItemDonation itemDonation);
    }
}
