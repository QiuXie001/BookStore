using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DBStandard;
using BookStore.DBStandard.Models;

namespace BookStore.Domain.Service
{
    public class CustomService
    {
        public DBContext DbContext { get; set; }
        public CustomService(DBContext dbContext)
        {
            DbContext = dbContext;
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
