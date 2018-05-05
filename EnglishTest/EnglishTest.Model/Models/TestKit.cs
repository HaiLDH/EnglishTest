using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Model.Models
{
    [Table("TestKit")]
    public class TestKit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestKitID { get; set; }

        [Required]
        public string TypeKitName { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public int Level { get; set; }

        public int Amount { get; set; }

        public int Minutes { get; set; }
    }
}
