using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IProductBL
    {
        List<Product> GetProducts();
        void AddProduct(Product newProduct);
        Product GetProductByName(string name);
        Product DeleteProduct(Product product2BDeleted);

        Product UpdateProduct(Product product2BUpdated);
    }
}