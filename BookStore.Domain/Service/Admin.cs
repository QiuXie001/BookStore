using BookStore.DBStandard.Models;

namespace BookStore.Domain.Service
{
    public class AdminService
    {
        public DBContext DbContext { get; set; }
        public AdminService(DBContext dbContext)
        {
            DbContext = dbContext;
        }
        public static Admin? GetAdminById(int Id) 
        {   
            var db = new DBContext();
            var admin = db.Admin.SingleOrDefault(a => a.Id == Id);
            return admin;
        }
        public List<Admin> GetAll()
        {
            var admins = DbContext.Admin.ToList();
            return admins;
        }
        public static void Register(Admin admin)
        {
            var db = new DBContext();
            db.Admin.Add(admin);
            db.SaveChanges();
        }
    }
}
