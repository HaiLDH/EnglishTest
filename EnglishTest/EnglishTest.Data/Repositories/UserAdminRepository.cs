﻿using EnglishTest.Data.Infrastructure;
using EnglishTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Data.Repositories
{
    public interface IUserAdminRepository : IRepositoryBase<UserAdmin>
    {

    }

    public class UserAdminRepository : RepositoryBase<UserAdmin>, IUserAdminRepository
    {
    }
}
