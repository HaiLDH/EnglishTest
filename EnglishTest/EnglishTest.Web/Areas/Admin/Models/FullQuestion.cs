using EnglishTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnglishTest.Web.Areas.Admin.Models
{
    public class FullQuestion
    {
        public IEnumerable<Question> Questions { get; set; }

        public IEnumerable<Answer> Answers { get; set; }
    }
}