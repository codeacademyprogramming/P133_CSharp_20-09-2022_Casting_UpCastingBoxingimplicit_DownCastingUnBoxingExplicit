using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models
{
    class Product
    {
        private static int _code;
        public static int TotalCount;

        public ProductType ProductType;
        public readonly string Code;
        public string Name;
        public double Price;
        public readonly double DiscountPrice;


        static Product()
        {
            _code = 1000;
            TotalCount = 0;
        }

        public Product(ProductType productType, double price)
        {
            _code++;
            TotalCount++;
            ProductType = productType;
            Price = price;

            Code = productType.ToString()[0].ToString() + _code;

            if(productType == ProductType.Bakery)
            {
                DiscountPrice = Price - (Price / 10);
            }

            //switch (productType)
            //{
            //    case ProductType.Bakery:
            //        DiscountPrice = Price - (Price / 10);
            //        Code = "B" + _code;
            //        break;
            //    case ProductType.Drink:
            //        Code = "D" + _code;
            //        break;
            //    case ProductType.Meat:
            //        Code = "M" + _code;
            //        break;
            //    case ProductType.Fish:
            //        Code = "F" + _code;
            //        break;
            //}
        }
    }
}
