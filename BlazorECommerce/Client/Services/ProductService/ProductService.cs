﻿using System.Diagnostics;

namespace BlazorECommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient http)
        {
            _httpClient = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public Product Product { get; set; } = new Product();

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productId}");
            return result;
        }
    }
}
