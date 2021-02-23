using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class ProductBL : IProductBL
    {
        private IProductRepository _repo;
        public ProductBL(IProductRepository repo)
        {
            _repo = repo;
        }
        public void AddProduct(Product newProduct)
        {
            //Todo: Add BL
            _repo.AddProduct(newProduct);
        }

        public List<Product> GetProducts()
        {
            //TODO add BL
            return _repo.GetProducts();
        }
    }
}