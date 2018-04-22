using EnglishTest.Data.Infrastructure;
using EnglishTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Data.Repositories
{
    public interface IPositionRepository : IRepositoryBase<Position>
    {

    }

    public class PositionRepository : RepositoryBase<Position>, IPositionRepository
    {
    }
}
