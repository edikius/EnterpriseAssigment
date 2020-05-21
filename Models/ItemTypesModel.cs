using ItemStoreProject.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStoreProject.Models
{
    public class ItemTypesModel
    {
        public List<ItemType> ItemTypes { get; set; }

        public List<Categories> CategoryList { get; set; }
        public string errorMessage { get; set; }

    }
}
