﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStoreProject.Persistence.Entities
{
    [Table("ItemType")]
    public class ItemType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ItemTypeId { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        [ForeignKey("Categories")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMappedAttribute]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }


    }
}
