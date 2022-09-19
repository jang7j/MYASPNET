namespace MYASPNET
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
