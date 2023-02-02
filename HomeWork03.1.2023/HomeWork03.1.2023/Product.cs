using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork03._1._2023
{
    internal class Product : Store
    {

        private string _productNo;
        public string Category;
        public double Price;

        public string ProductNumber
        {
            get => _productNo;
            set
            {
                if (IsValidProductNumber(value))
                    _productNo = value;
            }
        }
        public static bool IsValidProductNumber(string num)
        {
            if (string.IsNullOrWhiteSpace(num))
                return false;
            if (!char.IsLetter(num[0]))
                return false;
            for (int i = 1; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i]))
                    return false;
            }
            return true;
        }



    }
}
