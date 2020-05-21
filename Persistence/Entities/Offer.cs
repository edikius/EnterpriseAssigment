using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemStoreProject.Persistence.Entities
{
    public class Offer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Item Type is required")]
        public string ItemTypeId { get; set; }
        public string OwnerId { get; set; }

        [Required(ErrorMessage = "Quantity is Required")]
        public uint Quantity { get; set; }
        [Required(ErrorMessage = "Quality is required")]
        public string Quality { get; set; }
        [Range(0.01, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public decimal Price { get; set; }

    }
}