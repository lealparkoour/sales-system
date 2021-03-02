using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class SalesPro
    {
        Product[] Products = new Product[20];

        public int productsCount = 0;

        Seller[] Sellers = new Seller[20];
        int sellerCount = 0;

        Sale[] Sales = new Sale[600];
        public int salesCount = 0;


        public void Addsales(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }


        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void Addproducts(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }

        public double Average_Products()
        {
            double countValueOfProducts = 0;

            for (int i = 0; i <= productsCount - 1; i++)
            {
                if (Products[i].Price != 0)
                {
                    countValueOfProducts += Products[i].Price;
                }
            }

            countValueOfProducts = countValueOfProducts / productsCount;

            return countValueOfProducts;
        }


        public double ValueOfProducts()
        {
            double countValueOfProducts = 0;

            for (int i = 0; i <= productsCount - 1; i++)
            {
                if (Products[i].Price != 0)
                {
                    countValueOfProducts += Products[i].Price;
                }
            }

            return countValueOfProducts;
        }


        public string expensive_Product()
        {
            string nameProduct = "";

            double expensive = Products[0].Price;
            for (int i = 0; i <= productsCount - 1; i++)
            {

                if (expensive > Products[i].Price)
                {
                    expensive = Products[i].Price;
                }
                else
                {
                    nameProduct = Products[i].Name;
                }
            }

            return nameProduct;
        }

        public string seller_economic_Product()
        {
            string nameSellerProduct = "";

            double economic = Products[0].Price;

            for (int i = 0; i <= salesCount - 1; i++)
            {

                if (economic < Products[i].Price)
                {
                    economic = Products[i].Price;
                }
                else
                {
                    nameSellerProduct = Sales[i].SalesMan.Name;
                }
            }

            return nameSellerProduct;
        }
    }
}
