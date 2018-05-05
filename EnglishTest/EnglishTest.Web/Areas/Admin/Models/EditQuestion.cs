using EnglishTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnglishTest.Web.Areas.Admin.Models
{
    public class EditQuestion
    {
        public Question Question { get; set; }

        public IEnumerable<Answer> Answers { get; set; }

        public IEnumerable<Level> Levels { get; set; }

        public IEnumerable<TestKit> TestKits { get; set; }
    }
}