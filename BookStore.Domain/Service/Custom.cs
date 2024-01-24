using BookStore.DBStandard.Models;

namespace BookStore.Domain.Service
{
    public class CustomService(DBContext dbContext)
    {
        public DBContext DbContext { get; set; } = dbContext;
        public static Custom? GetCustomById(int Id) 
        {   
            var db = new DBContext();
            var custom = db.Custom.SingleOrDefault(a => a.Id == Id);
            return custom;
        }
        public List<Custom> GetAll()
        {
            var customs = DbContext.Custom.ToList();
            return customs;
        }
        public static void Register(Custom custom)
        {
            var db = new DBContext();
            db.Custom.Add(custom);
            db.SaveChanges();
        }
    }
}
