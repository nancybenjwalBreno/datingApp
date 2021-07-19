using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("AppUser")]
    public class AppUser
    {
        [Key]
        public int Id {get; set; }
        public string UserName {get; set; }
        public byte[] PasswordHash {get; set; }
        public byte[] PasswordSault {get; set; }
    }
}
