namespace SportsStore.Models
{
    public class DataRepository : IRepository
    {
        //private List<Product> data = new List<Product>();
        private DataContext _context;

        public DataRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products => _context.Products;

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
