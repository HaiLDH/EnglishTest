using EnglishTest.Model.Models;
using EnglishTest.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Service.Services
{
    public interface IResultService : IServiceBase<Result>
    {

    }

    public class ResultService : ServiceBase<Result>, IResultService
    {

    }
}
