using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data
{
    [Table("Organizations")]
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Mission { get; set; }

        [StringLength(100)]
        public string LogoFilePath { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<OrganizationUser> OrganizationUsers { get; set; }
    }
}
