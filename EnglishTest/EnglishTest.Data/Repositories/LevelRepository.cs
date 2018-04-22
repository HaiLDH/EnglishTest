using EnglishTest.Data.Infrastructure;
using EnglishTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Data.Repositories
{
    public interface ILevelRepository : IRepositoryBase<Level>
    {

    }

    public class LevelRepository : RepositoryBase<Level>, ILevelRepository
    {
    }
}
