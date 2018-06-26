using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Model.Models
{
    [Table("Footers")] // Attributes to perform name of the table in database
    public class Footer
    {
        [Key] // Declare primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }
    }
}
