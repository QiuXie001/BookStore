using BookStore.DBStandard.Models;

namespace BookStore.Domain.Service
{
    public class BookService(DBContext dbContext)
    {
        public DBContext DbContext { get; set; } = dbContext;

        public static List<Book>? GetAll()
        {
            var db = new DBContext();
            if(db.Book.Any())
            {
            var books = db.Book.ToList();
            return books;
            }
            return null;
        }
        public static void Add(Book book)
        {
            var db = new DBContext();
            db.Book.Add(book);
            db.SaveChanges();
        }
        public static void GetBookTypes()
        {
            
        }
    }
}
