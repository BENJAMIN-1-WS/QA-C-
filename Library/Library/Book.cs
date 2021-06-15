namespace Library
{
    public class Book
    {
        public enum BookType
        {
            Children,
            Adult
            // 
        }
        public enum BookStatus
        {
            InTheLibrary,
            Ordered,
            OutOfTheLibrary,
            OutOfTheLibrary_AndOrder
        }
        private BookStatus status;
        private string id;
        private BookType type;
        public BookStatus Status{ get { return status; } set { status = value; }}
        public string Id { get => id; set => id = value; }
        public BookType Type { get => type; set => type = value; }


        public Book(string book_id, BookType book_type, BookStatus book_status)
        {
            this.Id = book_id;
            this.Type = book_type;
            this.Status = book_status;
        }

    }
} 