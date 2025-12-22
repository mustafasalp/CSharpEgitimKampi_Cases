using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal: GenericRepository<Admin>, IAdminDal
    {
    }
}
