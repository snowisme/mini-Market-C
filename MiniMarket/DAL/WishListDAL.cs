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
    public class WishListDAL
    {
        private static List<Wishlist> _wishlists = new List<Wishlist>()
        {
            new Wishlist() { CustomerId = 1, ProductId = 1, ProductName = "Product 1" },
            new Wishlist() { CustomerId = 2, ProductId = 2, ProductName = "Product 2" },
            new Wishlist() { CustomerId = 3, ProductId = 3, ProductName = "Product 3" },
        };

        public WishListDAL() { }

        public List<Wishlist> GetBy(int customerId)
        {
            return _wishlists
                .Where(x => x.CustomerId == customerId)
                .ToList();
        }

        public int Insert(Wishlist wishList)
        {
            _wishlists.Add(wishList);
            return 1;
        }

        public bool Exits(int customerId, int productId)
        {
            return _wishlists
                .Any(x => x.CustomerId == customerId
                && x.ProductId == productId);
        }
    }
}
