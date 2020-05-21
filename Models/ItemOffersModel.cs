using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemStoreProject.Persistence.Entities;

namespace ItemStoreProject.Models
{
    public class ItemOffersModel
    {
        public List<Offer> ItemOffers { get; set; }
        public List<ItemType> ItemTypeList { get; set; }
        public string errorMessage { get; set; }
    }
}
