namespace BlazorECommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
