using System.Collections.Generic;

namespace SportsStore.Models
{
    public class DataRepository : IRepository
    {
        //private List<Product> data = new List<Product>();
        private DataContext context;
        public DataRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Product> Products => context.Products;
        public void AddProduct (Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();          
        }
        
    }
}
