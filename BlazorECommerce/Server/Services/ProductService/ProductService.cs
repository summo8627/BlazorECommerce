namespace BlazorECommerce.Server.Services.ProductService
{
    public class ProductService: IProductService
    {

        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetSingleProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var response = new ServiceResponse<Product>();
            if (product == null)
            {
                response.success = false;
                response.Message = "Sorry, Unable to find the product";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }
    }
}
