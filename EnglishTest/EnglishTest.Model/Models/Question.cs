﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Model.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }

        [Required]
        public string Content { get; set; }

        public int Level { get; set; }

        [Required]
        public int TestKitID { get; set; }

        [Required]
        public string CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
