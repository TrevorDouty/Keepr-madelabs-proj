using System.ComponentModel.DataAnnotations;

namespace Keepr.Web.Models
{
    public class Vault
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
        // public string CreatorId { get; set; }
        // public Profile Creator { get; set; }
    }
}