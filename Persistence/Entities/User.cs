using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ItemStoreProject.Persistence.Entities
{
    public class User : IdentityUser
    {
        /*public string Email { get; set; }
        public string UserName { get; set; }*/
    }
}
