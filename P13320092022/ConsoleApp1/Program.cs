using System;
using ConsoleApp1.Models;
using ConsoleApp1.Enums;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Product[] products = new Product[0];

            //do
            //{
            //    Console.WriteLine("Mehsulun Adini Daxil Et");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Mehsulun Novunu Sec");
            //    foreach (var item in Enum.GetValues(typeof(ProductType)))
            //    {
            //        Console.WriteLine((int)item + " " + item);
            //    }

            //    string productTypeStr = Console.ReadLine();

            //    int productTypeNum;

            //    while (!int.TryParse(productTypeStr, out productTypeNum) || productTypeNum < 1 || productTypeNum > 4)
            //    {
            //        Console.WriteLine("Duzgun Nov Secin:");
            //        productTypeStr = Console.ReadLine();
            //    }

            //    Console.WriteLine("Mehsulun Qiymetini Daxil Et:");
            //    string priceStr = Console.ReadLine();

            //    double priceNum;
            //    while (!double.TryParse(priceStr, out priceNum))
            //    {
            //        Console.WriteLine("Duzgun Qiymet Daxil Edin:");
            //        priceStr = Console.ReadLine();
            //    }

            //    Product product = new Product((ProductType)productTypeNum, priceNum);
            //    product.Name = name;

            //    Console.WriteLine("Yeni Mehsul Elave Etmek Isdiyirsizmi  y / n");
            //    string answer = Console.ReadLine();

            //    Array.Resize(ref products, products.Length + 1);
            //    products[products.Length - 1] = product;

            //    if (answer == "n")
            //    {
            //        break;
            //    }
            //} while (true);

            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"{product.Name}\n{product.Code}\n{product.Price}\n{product.DiscountPrice}\n{product.ProductType}\n{Product.TotalCount}");

            //}
            #endregion

            #region Task 2
            //int[] arr1 = { 4, 5, 2, 6, 4, 3 };
            //int[] arr2 = { 7, 4, 2, 76, 45, 65 };

            //int[] result = GetDifferent(arr1, arr2);

            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task 3
            int[] arr1 = { 4, 5, 2, 6, 4, 3 };
            ChangeToEven(ref arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        #region Task 2

        static int[] GetDifferent(int[] arr1, int[] arr2)
        {
            int[] results = { };

            foreach (int item1 in arr1)
            {
                bool check = false;
                foreach (int item2 in arr2)
                {
                    if (item1 == item2)
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                {
                    Array.Resize(ref results, results.Length + 1);
                    results[results.Length - 1] = item1;
                }
            }

            return results;
        }
        #endregion

        #region Task 3
        static void ChangeToEven(ref int[] arr)
        {
            int[] newArr = { };

            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }

            arr = newArr;
        }
        #endregion
    }
}
