using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Model.Models
{
    [Table("UserCandidate")]
    public class UserCandidate
    {
        [Key]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool Role { get; set; }

        [Required]
        public int LevelID { get; set; }

        [Required]
        public int PositionID { get; set; }

        [Required]
        public int UnitID { get; set; }

        public bool Mark { get; set; }

        public bool Status { get; set; }
    }
}
