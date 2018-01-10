namespace opdrachtweek6
{
    public class Book
        
    {
        public string name;
        public Author author;
        public double price;
        public int qtyInStock = 0;

        private List <Author> authors;
 
        public void Book(string name, Author author, double price, int qtyInStock) 
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qtyInStock = qtyInStock;
        } 

        public string getName() 
        {
            return this.name;
        }

        public Author getAuthor() 
        {
            return this.author;
        }

        public double getPrice() 
        {
            return this.price;
        }

        public int getQtyInStock() 
        {
            return this.qtyInStock;
        }

        public void setPrice(int price) 
        {
            price = price;
        }

        public void setQtyInStock(int qtyInStock) 
        {
            qtyInStock = qtyInStock;
        }

        public string getAuthorName()
        {
            return this.author;
        }

        public void print() 
        {
            Console.WriteLine("Book: {0}, {1}, {2} In Stock {3}", this.name, this.author, this.price, this.qtyInStock);
        }

        static void Main(string[] args)
        {
            Book books = new Book();
            books.print();
        }
    }
}