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
        public Product GetProductByName(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return _repo.GetProductByName(name);
        }
        public List<Product> GetProducts()
        {
            //TODO add BL
            return _repo.GetProducts();
        }

        public Product DeleteProduct(Product product2BDeleted)
        {
            return _repo.DeleteProduct(product2BDeleted);
        }
        public Product UpdateProduct(Product product2BUpdated)
        {
            return _repo.UpdateProduct(product2BUpdated);
        }
    }
}