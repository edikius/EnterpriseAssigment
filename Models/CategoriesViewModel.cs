using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;

namespace ItemStoreProject.Models
{
    public class CategoriesViewModel
    {
        public List<Categories> Categories { get; set; }
        public string ErrorMessage { get; set; }

    }
}
