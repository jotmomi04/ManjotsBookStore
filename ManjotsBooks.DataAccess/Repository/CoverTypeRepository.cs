using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManjotsBooks.DataAccess.Repository.IRepository;
using ManjotsBooks.Models;
using ManjotsBookStore.DataAccess.Data;

namespace ManjotsBooks.DataAccess.Repository
{
   public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
         
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) {
                objFromDb.Name = coverType.Name;

            }
        }
    }
}
