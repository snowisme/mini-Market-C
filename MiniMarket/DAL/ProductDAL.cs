using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniMarket.DAL
{
    public class ProductDAL
    {
        private WishListDAL _wishListDAL = new WishListDAL();

        private static List<Product> _products = new List<Product>()
        {
            new Product() { ProductId = 1, Image = "", ProductName = "Product 1", Quantity = 1, SalePrice = 5000, UnitId = 1, UnitName = "Kg" },
            new Product() { ProductId = 2, Image = "", ProductName = "Product 2", Quantity = 1, SalePrice = 5000, UnitId = 1, UnitName = "Kg" },
            new Product() { ProductId = 3, Image = "", ProductName = "Product 3", Quantity = 1, SalePrice = 5000, UnitId = 1, UnitName = "Kg" },
            new Product() { ProductId = 4, Image = "", ProductName = "Product 4", Quantity = 1, SalePrice = 5000, UnitId = 1, UnitName = "Kg" },
        };

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetOutStockProduct()
        {
            return _products.Where(x => x.Quantity <= 0)
                .ToList();
        }

        public List<Product> GetAllProductInWishList(int customerId)
        {
            List<Wishlist> wishlists = _wishListDAL.GetBy(customerId);
            List<Product> wishListProducts = new List<Product>();
            
            foreach (var wishList in  wishlists)
            {
                var product = _products.FirstOrDefault( x => x.ProductId == wishList.ProductId);

                if (product != null)
                    wishListProducts.Add(product);
            }

            return wishListProducts;
        }


        public int Insert(Product product)
        {
            int newId = _products.Max(x => x.ProductId) + 1;
            product.ProductId = newId;
            _products.Add(product);
            return newId;
        }

        public int Update(Product product)
        {
            var old = _products.Where(x => x.ProductId == product.ProductId).
                FirstOrDefault();

            if (old != null)
            {
                old.ProductName = product.ProductName;
                old.Quantity = product.Quantity;
                old.SalePrice = product.SalePrice;
                old.Image = product.Image;

                return 1;
            }

            return -1;
        }

        public int SubtractQuantiy(int productId, int quantity)
        {
            var old = _products.Where(x => x.ProductId == productId).
                FirstOrDefault();

            if (old != null)
            {
                old.Quantity = old.Quantity - quantity;

                return old.Quantity;
            }

            return int.MaxValue;
        }

        public int UpdateImport(int productId, int quantity)
        {
            var old = _products.Where(x => x.ProductId == productId).
                FirstOrDefault();

            if (old != null)
            {
                old.Quantity = old.Quantity + quantity;

                return old.Quantity;
            }

            return -1;
        }


        public int Delete(int productId)
        {
            var old = _products.Where(x => x.ProductId == productId).
                FirstOrDefault();

            if (old != null)
            {
                _products.Remove(old);
                return 1;
            }

            return -1;
        }

        public List<Product> SearchByName(string productName)
        {
            return _products
                .Where(x => x.ProductName.Contains(productName))
                .ToList();
        }
    }
}
