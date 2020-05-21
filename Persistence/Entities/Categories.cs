using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStoreProject.Persistence.Entities
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        public string CategoryName { get; set; }
    }
}
