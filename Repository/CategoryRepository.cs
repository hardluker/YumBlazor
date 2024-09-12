using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        //Implementation of the record creation
        public Category Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        //Implementation of the record deletion
        public bool Delete(int id)
        {
            var obj = _db.Category.FirstOrDefault(u =>  u.Id == id);
            if (obj != null)
            {
                _db.Category.Remove(obj);
                return _db.SaveChanges() > 0;
            }
            return false;
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
