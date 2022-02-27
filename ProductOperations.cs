using System;
using System.Windows;

namespace PetalFreshKonweter
{
    public class ProductOperations 
    {
        public void SetManufactureDate(Product product)
        {
            double days = Convert.ToDouble(product.SerialCode.Substring(0, 3));
            int year = Convert.ToInt32(product.SerialCode.Substring(3, 2));

            product.ManufactureDate = new DateTime(year + 2000, 1, 1);
            product.ManufactureDate = product.ManufactureDate.AddDays(days);
        }
        public void SetShelfLife(Product product)
        {
            char lastindexofserialcodevalue = product.SerialCode[product.SerialCode.Length - 1];

            string letters = "ABCDEFGHIJKL";

            if (product.SerialCode.Contains(lastindexofserialcodevalue))
            {
                product.ShelfLife = product.ManufactureDate.AddYears(letters.IndexOf(lastindexofserialcodevalue) + 1);
            }
        }
        public void SetSerialCode(Product product,string input)
        {
            product.SerialCode = input;            
        }
    }
}
