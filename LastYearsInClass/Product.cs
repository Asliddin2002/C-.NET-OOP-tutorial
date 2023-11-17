using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastYearsInClass
{
    public class Product
    {
        List<Department> Products = new List<Department>();

        private static Product _product = null;

        public static Product GetProduct ()
        {
            if( _product == null ) return new Product();

            return _product;
        }

        public void GenerateSampleData()
        {
            Baby Doll = new Baby()
            {
                Title = "Doll",
                Category = Category.Baby,
                dealType = deals.All,
                Description = "Very Good Doll",
                Price = 10,
                DealId = 1,
                CategoryId = 1,
                forAge = 3
            };

            Baby ToyCar = new Baby()
            {
                Title = "Toy Car",
                Category = Category.Baby,
                dealType = deals.Top,
                Description = "Very Good Car Toy",
                Price = 8,
                DealId = 2,
                CategoryId = 1,
                forAge = 5
            };

            Baby ToyTablet = new Baby()
            {
                Title = "Toy Tablet",
                Category = Category.Baby,
                dealType = deals.Best,
                Description = "Very Good Tablet Toy",
                Price = 20,
                DealId = 3,
                CategoryId = 1,
                forAge = 7
            };

            Books book1 = new Books()
            {
                Title = "Garry",
                Category = Category.Books,
                dealType = deals.Top,
                Description = "Very Good Book Ever",
                Price = 12,
                DealId = 2,
                CategoryId = 4,
                Author = "John Doe"
            };

            Devices phone = new Devices()
            {
                Title = "Iphone 15",
                Category = Category.Device,
                dealType = deals.Best,
                Description = "Very Good Phone Ever",
                Price = 1500,
                DealId = 3,
                CategoryId = 3,
                screenSize = "414px-816px"
            };

            Electronics lamp = new Electronics()
            {
                Title = "Artel lamp",
                Category = Category.Electronic,
                dealType = deals.All,
                Description = "Very Good Lamp Ever",
                Price = 5,
                DealId = 1,
                CategoryId = 2,
                Gaurantee = "1 year"
            };

            Products.Add(Doll);
            Products.Add(ToyTablet);
            Products.Add(ToyCar);
            Products.Add(book1);
            Products.Add(phone);
            Products.Add(lamp);


        }

        public void DisplayProducts (string departmentId, string dealId = "")
        {
            Products.ForEach((Department product) =>
            {
            if (departmentId != null && Convert.ToString( product.CategoryId) == departmentId) 
                {
                    if(dealId != "" && Convert.ToString(product.DealId) == dealId)
                    {
                        Console.WriteLine($"{product.Title} {product.Price}");
                    } else
                    {
                        Console.WriteLine($"{product.Title} {product.Price}");

                    }
                }
            });
        }
    }
}
