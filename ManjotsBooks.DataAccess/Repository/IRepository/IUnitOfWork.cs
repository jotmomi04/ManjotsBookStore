using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManjotsBooks.DataAccess.Repository.IRepository
{
  public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
