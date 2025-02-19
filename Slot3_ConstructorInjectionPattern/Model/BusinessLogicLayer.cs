namespace Slot3_ConstructorInjectionPattern.Model
{
    public class BookManager
    {
        public IBookReader bookReader;
        public BookManager(IBookReader bookReader)
        {
            this.bookReader = bookReader;
        }
        public void ReadBooks()
        {
            bookReader.ReadBooks();
        }
    }
}
