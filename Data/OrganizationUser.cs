using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data
{
    [Table("OrganizationUsers")]
    public class OrganizationUser
    {
        [Key]
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
