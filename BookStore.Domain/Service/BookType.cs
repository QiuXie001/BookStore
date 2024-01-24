using BookStore.DBStandard.Models;

namespace BookStore.Domain.Service
{
    public class BookTypeService(DBContext dbContext)
    {
        public DBContext DbContext { get; set; } = dbContext;

        public static List<BookType>? GetAll()
        {
            var db = new DBContext();
            if (db.BookType.Any())
            {
                var booktypes = db.BookType.ToList();
                return booktypes;
            }
            return null;
        }
        public static void Add(BookType bookType)
        {
            var db = new DBContext();
            db.BookType.Add(bookType);
            db.SaveChanges();
        }
        public static void Remove(BookType bookType)
        {
            var db = new DBContext();
            db.BookType.Remove(bookType);
            db.SaveChanges();
        }
    }
}
