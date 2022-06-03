using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWTbearerAuthenticationCoreWebAPI.Models
{
    public class SecurityQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SqId { get; set; }

        [DisplayName("Select security question")]
        [Required(ErrorMessage = "Security Question should not be blank")]
        public string Question { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
