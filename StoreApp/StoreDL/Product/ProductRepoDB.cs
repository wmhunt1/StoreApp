using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class ProductRepoDB : IProductRepository
    {
        private readonly StoreDBContext _context;
        public ProductRepoDB(StoreDBContext context)
        {
            _context = context;
        }
        public Product AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public Product DeleteProduct(Product product2BDeleted)
        {
            _context.Products.Remove(product2BDeleted);
            _context.SaveChanges();
            return product2BDeleted;
        }

        public Product GetProductByName(string name)
        {
            return _context.Products
                .AsNoTracking()
                .FirstOrDefault(product => product.ProductName == name);
        }

        public List<Product> GetProducts()
        {
            return _context.Products
                .AsNoTracking()
                .Select(product => product)
                .ToList();
        }

        public Product UpdateProduct(Product product2BUpdated)
        {
            return product2BUpdated;
        }
    }
    
}