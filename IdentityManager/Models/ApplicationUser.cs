using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
    //axali propertis damateba useristvis , unda iyos identity useris memkvidre rom mixvdes bazis userzeromaa saubari
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
