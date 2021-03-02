using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPro saless = new SalesPro();


            Product p1 = new Product();
            p1.Name = "cellphones";
            p1.Price = 120000;
            saless.Addproducts(p1);

            Product p2 = new Product();
            p2.Name = "headphones";
            p2.Price = 150000;
            saless.Addproducts(p2);

            Product p3 = new Product();
            p3.Name = "case for cell phone";
            p3.Price = 180000;
            saless.Addproducts(p3);

            Seller s1 = new Seller();
            s1.Name = "Andres";
            s1.Age = 25;
            saless.AddSeller(s1);


            Seller s2 = new Seller();
            s2.Name = "Milena";
            s2.Age = 21;
            saless.AddSeller(s2);


            Seller s3 = new Seller();
            s3.Name = "lina";
            s3.Age = 20;
            saless.AddSeller(s3);

            Sale sale = new Sale();
            sale.SalesMan = s1;
            sale.Product = p1;
            sale.Comments = "without discount";
            saless.Addsales(sale);

            Sale sale1 = new Sale();
            sale1.SalesMan = s2;
            sale1.Product = p2;
            sale1.Comments = "without discount";
            saless.Addsales(sale1);

            Sale sale2 = new Sale();
            sale2.SalesMan = s3;
            sale2.Product = p3;
            sale2.Comments = "without discount";
            saless.Addsales(sale2);


            //double Total = sale.Product.Price + sale1.Product.Price + sale2.Product.Price;




            //System.Console.WriteLine("Sales total amount: " + Total);

            //System.Console.WriteLine("sales made by:\n" + sale.SalesMan.Name + "\n" + sale1.SalesMan.Name + "\n" + sale2.SalesMan.Name);


            //The product more economic Seller
            Console.WriteLine("The cheapest product was sold by " + saless.seller_economic_Product());

            //Average of Products
           Console.WriteLine("The quantity of products is " + saless.productsCount +
                              " The Value total of products is " + saless.ValueOfProducts() +
                               " The average value of products is " + saless.Average_Products());
            
            //The quantity of products is 
            Console.WriteLine("The quantity of sales is " + saless.salesCount);


            //economic product
            Console.WriteLine("The product more expensive is " + saless.expensive_Product());

        }




    }

    }



